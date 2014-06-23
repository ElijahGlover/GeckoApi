using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("companies", "company")]
    public class Company
    {
        public int? Id { get; set; }
        [JsonProperty("assignee_id")]
        public int? AssigneeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        [JsonProperty("company_type")]
        public string CompanyType { get; set; }
        [JsonProperty("company_code")]
        public string CompanyCode { get; set; }
        public string Fax { get; set; }
        [JsonProperty("default_tax_rate")]
        public decimal? DefaultTaxRate { get; set; }
        [JsonProperty("default_discount_rate")]
        public decimal? DefaultDiscountRate { get; set; }
        [JsonProperty("default_price_type_id")]
        public string DefaultPriceTypeId { get; set; }
        [JsonProperty("default_payment_term_id")]
        public int? DefaultPaymentTermId { get; set; }
        [JsonProperty("address_ids")]
        public int[] AddressIds { get; set; }
        [JsonProperty("contact_ids")]
        public int[] ContactIds { get; set; }
        [JsonProperty("note_ids")]
        public int[] NoteIds { get; set; }
    }
}
