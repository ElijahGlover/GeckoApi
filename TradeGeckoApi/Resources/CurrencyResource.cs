using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class CurrencyResource : Resource<Currency>
    {
        public CurrencyResource(IRequestService authentication) : base(authentication) { }

        public CurrencyResource() { }

        protected override string ResourceUri { get { return "/currencies"; } }
        protected override string ResourceItemUri { get { return "/currencies/{id}"; } }

        protected override object ResolveIdFromModel(Currency model)
        {
            return model.Id;
        }
    }
}
