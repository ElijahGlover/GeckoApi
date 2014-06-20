using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class OrderResource : Resource<Order>
    {
        public OrderResource(IRequestService requestService) : base(requestService) { }

        public OrderResource() { }

        protected override string ResourceUri { get { return "/orders"; } }
        protected override string ResourceItemUri { get { return "/orders/{id}"; } }

        protected override object ResolveIdFromModel(Order model)
        {
            return model.Id;
        }

        public virtual IPaginationList<Order> ByCompanyId(int companyId)
        {
            return List(Filters.ByCompany(companyId));
        }

        public virtual IPaginationList<Order> ByOrderNumber(string orderNumber)
        {
            return List(Filters.ByOrderNumber(orderNumber));
        }
    }
}
