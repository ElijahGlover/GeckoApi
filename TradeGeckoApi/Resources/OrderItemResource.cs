using TradeGeckoApi.Model;
using TradeGeckoApi.Service;

namespace TradeGeckoApi.Resources
{
    public class OrderItemResource : Resource<OrderItem>
    {
        public OrderItemResource(IRequestService requestService) : base(requestService) { }

        public OrderItemResource() { }

        protected override string ResourceUri { get { return "/order_line_items"; } }
        protected override string ResourceItemUri { get { return "/order_line_items/{id}"; } }

        protected override object ResolveIdFromModel(OrderItem model)
        {
            return model.Id;
        }

        public virtual IPaginationList<OrderItem> ByOrderId(int orderId)
        {
            return List(Filters.ByOrder(orderId));
        }
    }
}
