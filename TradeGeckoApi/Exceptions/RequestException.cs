using System;
using System.Runtime.Serialization;
using RestSharp;

namespace TradeGeckoApi.Exceptions
{
    [Serializable]
    public class RequestException : Exception
    {
        private readonly IRestResponse _response;

        public RequestException(IRestResponse response)
        {
            _response = response;
        }

        public RequestException(string message, IRestResponse response) : base(message)
        {
            _response = response;
        }

        public RequestException(string message, Exception innerException, IRestResponse response) : base(message, innerException)
        {
            _response = response;
        }

        protected RequestException(SerializationInfo info, StreamingContext context, IRestResponse response) : base(info, context)
        {
            _response = response;
        }

        public IRestResponse Response
        {
            get { return _response; }
        }
    }
}
