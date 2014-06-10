using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("locations", "location")]
    public class Location
    {
        public int? Id { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        public string Label { get; set; }
    }
}
