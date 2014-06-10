using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class AddressResource : Resource<Address>
    {
        public AddressResource(IRequestService client) : base(client) { }

        public AddressResource() { }

        protected override string ResourceUri { get { return "/addresses"; } }
        protected override string ResourceItemUri { get { return "/addresses/{id}"; } }

        protected override object ResolveIdFromModel(Address model)
        {
            return model.Id;
        }

        public virtual IPaginationList<Address> ByCompanyId(int companyId)
        {
            return List(Filters.ByCompany(companyId));
        }
    }
}
