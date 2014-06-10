using RestSharp;
using TradeGeckoApi.Model;

namespace TradeGeckoApi.Service
{
    public interface IRequestService
    {
        IPaginationList<T> ExecuteListRequest<T>(RestRequest request);
        T ExecuteRequest<T>(RestRequest request);
        void ExecuteRequest(RestRequest request);
    }
}