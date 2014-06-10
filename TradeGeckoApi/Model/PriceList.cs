using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("price_lists", "price_list")]
    public class PriceList
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [JsonProperty("is_cost")]
        public bool IsCost { get; set; }
        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }
        [JsonProperty("currency_id")]
        public int CurrencyId { get; set; }
        [JsonProperty("currency_iso")]
        public string CurrencyIso { get; set; }
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }
        public int Position { get; set; }
    }
}
