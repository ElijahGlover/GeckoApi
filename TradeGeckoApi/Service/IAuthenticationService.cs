using System;
using RestSharp;

namespace TradeGeckoApi.Service
{
    public interface IAuthenticationService
    {
        void SetAuthorizeCode(string code);
        IAuthenticator CreateRequestAuthenticator();
        Uri GenerateAuthorizeUrl();
    }
}