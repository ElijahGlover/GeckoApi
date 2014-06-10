using Newtonsoft.Json;

namespace TradeGeckoApi.Model
{
    public class VariantLocation
    {
        [JsonProperty("location_id")]
        public int? LocationId { get; set; }
        [JsonProperty("stock_on_hand")]
        public decimal StockOnHand { get; set; }
        [JsonProperty("committed_stock")]
        public decimal CommittedStock { get; set; }
    }
}
