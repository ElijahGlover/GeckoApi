using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("contacts", "contact")]
    public class Contact
    {
        public int? Id { get; set; }
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Mobile { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Notes { get; set; }
        public string Position { get; set; }
    }
}
