using System.Linq;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using TradeGeckoApi.Exceptions;
using TradeGeckoApi.Model;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Service
{
    public class RequestService : IRequestService
    {
        private readonly IAuthenticationService _authentication;
        private readonly string _baseUrl;
        public const string PaginationHeader = "X-Pagination";

        public RequestService(IAuthenticationService authentication, string baseUrl)
        {
            _authentication = authentication;
            _baseUrl = baseUrl;
        }

        public RestClient CreateClient()
        {
            var client = new RestClient(_baseUrl)
            {
                Authenticator = _authentication.CreateRequestAuthenticator()
            };
            client.AddHandler("application/json", new JsonNetDeserializer());
            return client;
        }

        public void ExecuteRequest(RestRequest request)
        {
            var client = CreateClient();
            var response = client.Execute(request);
            InspectResponse(response);
        }

        public T ExecuteRequest<T>(RestRequest request)
        {
            var client = CreateClient();
            var response = client.Execute<ItemResponse<T>>(request);
            InspectResponse(response);
            return response.Data.Data;
        }

        public IPaginationList<T> ExecuteListRequest<T>(RestRequest request)
        {
            var client = CreateClient();
            var response = client.Execute<ListResponse<T>>(request);
            InspectResponse(response);

            var paginationHeader = response.Headers.FirstOrDefault(p => p.Name == PaginationHeader);

            var pagination = paginationHeader != null
                ? JsonConvert.DeserializeObject<PaginationModel>(paginationHeader.Value.ToString())
                : null;

            return new PaginationList<T>(response.Data.Data, pagination);
        }

        protected void InspectResponse(IRestResponse response)
        {
            if (response.ErrorException != null)
                throw new RequestException("Exception was raised executing request", response.ErrorException, response);

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new NotFoundException(string.Format("Resource With Uri '{0}' Couldn't Be Found", response.ResponseUri), response);

            if (response.StatusCode == HttpStatusCode.BadRequest)
                throw new InvalidRequestException("Request was rejected by the server as it was malformed", response);

            if (response.StatusCode == HttpStatusCode.Forbidden)
                throw new AuthenticationException("Request ApiId or Signature Invalid", response);

            if ((int)response.StatusCode >= 300)
                throw new RequestException(string.Format("There was a problem processing the request {0}", response.Content), response);
        }
    }
}
