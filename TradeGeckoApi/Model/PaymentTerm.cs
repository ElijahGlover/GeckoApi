using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("payment_terms", "payment_term")]
    public class PaymentTerm
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("due_in_days")]
        public int DueInDays { get; set; }
        public string Status { get; set; }
    }
}
