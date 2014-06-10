using System;

namespace TradeGeckoApi.Exceptions
{
    [Serializable]
    public class NotFoundException : RequestException
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }

        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
