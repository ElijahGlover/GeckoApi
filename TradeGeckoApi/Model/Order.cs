using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("orders", "order")]
    public class Order
    {
        public int? Id { get; set; }
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }
        [JsonProperty("shipping_address_id")]
        public int ShippingAddressId { get; set; }
        [JsonProperty("billing_address_id")]
        public int BillingAddressId { get; set; }
        [JsonProperty("assignee_id")]
        public int AssigneeId { get; set; }
        [JsonProperty("stock_location_id")]
        public int StockLocationId { get; set; }
        [JsonProperty("currency_id")]
        public int CurrencyId { get; set; }
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
        public string Status { get; set; }
        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }
        [JsonProperty("tax_type")]
        public string TaxType { get; set; }
        [JsonProperty("issued_at")]
        public DateTime? IssuedAt { get; set; }
        [JsonProperty("ship_at")]
        public DateTime? ShipAt { get; set; }
        [JsonProperty("order_line_items")]
        public IList<OrderItem> OrderItems { get; set; }
        [JsonProperty("order_line_item_ids")]
        public int[] OrderLineItemIds { get; set; }
        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
        [JsonProperty("source_id")]
        public string SourceId { get; set; }
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
