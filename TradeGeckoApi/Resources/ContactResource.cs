using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class ContactResource : Resource<Contact>
    {
        public ContactResource(IRequestService requestService) : base(requestService) { }

        public ContactResource() { }

        protected override string ResourceUri { get { return "/contacts"; } }
        protected override string ResourceItemUri { get { return "/contacts/{id}"; } }

        protected override object ResolveIdFromModel(Contact model)
        {
            return model.Id;
        }

        public virtual IPaginationList<Contact> ByCompanyId(int companyId)
        {
            return List(Filters.ByCompany(companyId));
        }
    }
}
