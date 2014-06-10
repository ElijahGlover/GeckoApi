using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("order_line_items", "order_line_item")]
    public class OrderItem
    {
        public int? Id { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        [JsonProperty("variant_id")]
        public int VariantId { get; set; }
        public bool Freeform { get; set; }
        public int Position { get; set; }
        [JsonProperty("order_id")]
        public int? OrderId { get; set; }
        public decimal? Discount { get; set; }
        public string Label { get; set; }
        [JsonProperty("tax_rate")]
        public decimal? TaxRate { get; set; }
    }
}
