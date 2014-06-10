using System.Collections.Generic;

namespace TradeGeckoApi.Model
{
    public class ListResponse<T>
    {
        public IList<T> Data { get; set; }
    }
}
