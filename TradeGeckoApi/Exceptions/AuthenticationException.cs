using System;
using System.Runtime.Serialization;
using RestSharp;

namespace TradeGeckoApi.Exceptions
{
    [Serializable]
    public class AuthenticationException : RequestException
    {
        public AuthenticationException(IRestResponse response) : base(response)
        {
        }

        public AuthenticationException(string message, IRestResponse response) : base(message, response)
        {
        }

        public AuthenticationException(string message, Exception innerException, IRestResponse response) : base(message, innerException, response)
        {
        }

        protected AuthenticationException(SerializationInfo info, StreamingContext context, IRestResponse response) : base(info, context, response)
        {
        }
    }
}
