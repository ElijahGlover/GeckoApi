using Newtonsoft.Json;

namespace TradeGeckoApi.Model
{
    public class VariantPrice
    {
        [JsonProperty("price_list_id")]
        public string PriceListId { get; set; }
        public decimal? Value { get; set; }
    }
}