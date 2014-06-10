using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class CompanyResource : Resource<Company>
    {
        public CompanyResource(IRequestService client) : base(client) { }

        public CompanyResource() { }

        protected override string ResourceUri { get { return "/companies"; } }
        protected override string ResourceItemUri { get { return "/companies/{id}"; } }

        protected override object ResolveIdFromModel(Company model)
        {
            return model.Id;
        }
    }
}
