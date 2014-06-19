using System;
using System.Runtime.Serialization;
using RestSharp;

namespace TradeGeckoApi.Exceptions
{
    [Serializable]
    public class NotFoundException : RequestException
    {
        public NotFoundException(IRestResponse response) : base(response)
        {
        }

        public NotFoundException(string message, IRestResponse response) : base(message, response)
        {
        }

        public NotFoundException(string message, Exception innerException, IRestResponse response) : base(message, innerException, response)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context, IRestResponse response) : base(info, context, response)
        {
        }
    }
}
