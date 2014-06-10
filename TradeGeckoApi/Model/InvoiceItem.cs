using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("invoice_line_items", "invoice_line_item")]
    public class InvoiceItem
    {
        public int? Id { get; set; }
        [JsonProperty("invoice_id")]
        public int InvoiceId { get; set; }
        [JsonProperty("order_line_item_id")]
        public int OrderLineItemId { get; set; }
        public double Quantity { get; set; }
        public int? Position { get; set; }
    }
}
