using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("fulfillments", "fulfillment")]
    public class Fulfillment
    {
        public int? Id { get; set; }
        [JsonProperty("order_id")]
        public int OrderId { get; set; }
        public string Status { get; set; }
        [JsonProperty("shipped_at")]
        public DateTime? ShippedAt { get; set; }
        [JsonProperty("received_at")]
        public DateTime? ReceivedAt { get; set; }
        [JsonProperty("packed_at")]
        public DateTime? PackedAt { get; set; }
        [JsonProperty("delivery_type")]
        public string DeliveryType { get; set; }
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }
        [JsonProperty("tracking_company")]
        public string TrackingCompany { get; set; }
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("shipping_address_id")]
        public int? ShippingAddressId { get; set; }
        [JsonProperty("billing_address_id")]
        public int? BillingAddressId { get; set; }
        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }
        public Guid? Xero { get; set; }
        public string Notes { get; set; }
        [JsonProperty("fulfillment_line_items")]
        public IList<FulfillmentItem> Items { get; set; }
    }
}
