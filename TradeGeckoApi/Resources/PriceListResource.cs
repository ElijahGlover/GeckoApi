using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class PriceListResource : Resource<PriceList>
    {
        public PriceListResource(IRequestService requestService) : base(requestService) { }

        public PriceListResource() { }

        protected override string ResourceUri { get { return "/price_lists"; } }
        protected override string ResourceItemUri { get { return "/price_lists/{id}"; } }

        protected override object ResolveIdFromModel(PriceList model)
        {
            return model.Id;
        }
    }
}
