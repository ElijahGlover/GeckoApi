using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("fulfillment_items", "fulfillment_item")]
    public class FulfillmentItem
    {
        public int? Id { get; set; }
        [JsonProperty("fulfillment_id")]
        public int? FulfillmentId { get; set; }
        [JsonProperty("order_line_item_id")]
        public int OrderLineItemId { get; set; }
        public double Quantity { get; set; }
        [JsonProperty("base_price")]
        public decimal? BasePrice { get; set; }
    }
}
