using System;
using System.Runtime.Serialization;
using RestSharp;

namespace TradeGeckoApi.Exceptions
{
    [Serializable]
    public class InvalidRequestException : RequestException
    {
        public InvalidRequestException(IRestResponse response) : base(response)
        {
        }

        public InvalidRequestException(string message, IRestResponse response) : base(message, response)
        {
        }

        public InvalidRequestException(string message, Exception innerException, IRestResponse response) : base(message, innerException, response)
        {
        }

        protected InvalidRequestException(SerializationInfo info, StreamingContext context, IRestResponse response) : base(info, context, response)
        {
        }
    }
}
