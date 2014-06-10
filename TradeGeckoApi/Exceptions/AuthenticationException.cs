using System;

namespace TradeGeckoApi.Exceptions
{
    [Serializable]
    public class AuthenticationException : RequestException
    {
        public AuthenticationException()
        {
        }

        public AuthenticationException(string message)
            : base(message)
        {
        }

        public AuthenticationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
