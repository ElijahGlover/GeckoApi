using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class FulfillmentItemResource : Resource<FulfillmentItem>
    {
        public FulfillmentItemResource(IRequestService client) : base(client) { }

        public FulfillmentItemResource() { }

        protected override string ResourceUri { get { return "/fulfillment_line_items"; } }
        protected override string ResourceItemUri { get { return "/fulfillment_line_items/{id}"; } }

        protected override object ResolveIdFromModel(FulfillmentItem model)
        {
            return model.Id;
        }

        public virtual IPaginationList<FulfillmentItem> ByFulfillmentId(int fulfillmentId)
        {
            return List(Filters.ByFulfillment(fulfillmentId));
        }
    }
}
