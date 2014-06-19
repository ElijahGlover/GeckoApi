using System;
using System.Linq;
using System.Net;
using RestSharp;
using TradeGeckoApi.Context;
using TradeGeckoApi.Exceptions;
using TradeGeckoApi.Model;

namespace TradeGeckoApi.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly string _applicationId;
        private readonly string _secret;
        private readonly string _callbackUrl;
        private readonly string _baseUrl;

        private string _authorizeCode;
        private string _accessToken;
        private string _refreshToken;
        private DateTime _tokenExpiry;

        public AuthenticationService(string applicationId, string secret, string callbackUrl, string baseUrl)
        {
            _applicationId = applicationId;
            _secret = secret;
            _callbackUrl = callbackUrl;
            _baseUrl = baseUrl;
        }

        private void LoadAuthenticationTokens()
        {
            using (var context = new OAuthDataContext())
            {
                var auth = context.OAuthAuthentication.FirstOrDefault();
                if (auth == null)
                    return;

                _accessToken = auth.AccessToken;
                _refreshToken = auth.RefreshToken;
                _tokenExpiry = auth.Expiry;
                _authorizeCode = auth.AuthorizeCode;
                context.SaveChanges();
            }
        }

        private void PersistAuthenticationTokens()
        {
            using (var context = new OAuthDataContext())
            {
                context.Database.ExecuteSqlCommand("DELETE FROM [OAuthAuthentications]");

                var item = new OAuthAuthentication();
                item.AccessToken = _accessToken;
                item.RefreshToken = _refreshToken;
                item.Expiry = _tokenExpiry;
                item.AuthorizeCode = _authorizeCode;
                context.OAuthAuthentication.Add(item);
                context.SaveChanges();
            }
        }

        private void GenerateToken()
        {
            var request = new RestRequest("/oauth/token", Method.POST);
            request.AddParameter("client_id", _applicationId, ParameterType.GetOrPost);
            request.AddParameter("client_secret", _secret, ParameterType.GetOrPost);
            
            request.AddParameter("redirect_uri", _callbackUrl, ParameterType.GetOrPost);
            if (string.IsNullOrEmpty(_refreshToken))
            {
                request.AddParameter("grant_type", "authorization_code", ParameterType.GetOrPost);
                request.AddParameter("code", _authorizeCode, ParameterType.GetOrPost);
            }
            else
            {
                request.AddParameter("grant_type", "refresh_token", ParameterType.GetOrPost);
                request.AddParameter("refresh_token", _refreshToken, ParameterType.GetOrPost);
            }

            var client = new RestClient(_baseUrl);
            var response = client.Execute<TokenResponse>(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new AuthenticationException("Error Getting Request Bearer Token", null, response);

            _accessToken = response.Data.AccessToken;
            _refreshToken = response.Data.RefreshToken;
            _tokenExpiry = DateTime.UtcNow.AddSeconds(response.Data.ExpiresIn - 20);
            PersistAuthenticationTokens();
        }

        public Uri GenerateAuthorizeUrl()
        {
            return new Uri(string.Format("{0}oauth/authorize?response_type=code&client_id={1}&redirect_uri={2}", _baseUrl, _applicationId, _callbackUrl));
        }

        public void SetAuthorizeCode(string code)
        {
            _authorizeCode = code;
            GenerateToken();
        }

        public IAuthenticator CreateRequestAuthenticator()
        {
            if (string.IsNullOrEmpty(_refreshToken))
                LoadAuthenticationTokens();

            if (_tokenExpiry < DateTime.UtcNow)
                GenerateToken();

            return new OAuth2AuthorizationRequestHeaderAuthenticator(_accessToken, "Bearer");
        }
    }
}
