using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class FulfillmentResource : Resource<Fulfillment>
    {
        public FulfillmentResource(IRequestService client) : base(client) { }

        public FulfillmentResource() { }

        protected override string ResourceUri { get { return "/fulfillments"; } }
        protected override string ResourceItemUri { get { return "/fulfillments/{id}"; } }

        protected override object ResolveIdFromModel(Fulfillment model)
        {
            return model.Id;
        }

        public virtual IPaginationList<Fulfillment> ByOrderId(int orderId)
        {
            return List(Filters.ByOrder(orderId));
        }
    }
}
