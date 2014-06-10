using System.Collections.Generic;

namespace TradeGeckoApi.Model
{
    public interface IPaginationList<T> : IList<T>
    {
        int TotalRecords { get; }
        int TotalPages { get; }
        bool FirstPage { get; }
        bool LastPage { get; }
        bool OutOfBounds { get; }
        int Offset { get; }
    }
}
