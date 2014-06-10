using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("addresses", "address")]
    public class Address
    {
        public int? Id { get; set; }
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }
        public string City { get; set; }
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Label { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
