using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("invoices", "invoice")]
    public class Invoice
    {
        public int? Id { get; set; }
        [JsonProperty("order_id")]
        public int OrderId { get; set; }
        [JsonProperty("shipping_address_id")]
        public int? ShippingAddressId { get; set; }
        [JsonProperty("billing_address_id")]
        public int? BillingAddressId { get; set; }
        [JsonProperty("payment_term_id")]
        public int? PaymentTermId { get; set; }
        public string Xero { get; set; }
        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }
        [JsonProperty("invoiced_at")]
        public string InvoicedAt { get; set; }
        [JsonProperty("due_at")]
        public string DueAt { get; set; }
        public string Notes { get; set; }
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("exchange_rate")]
        public decimal ExchangeRate { get; set; }
        [JsonProperty("invoice_line_item_ids")]
        public int[] InvoiceLineItemIds { get; set; }
        [JsonProperty("invoice_line_items")]
        public IList<InvoiceItem> InvoiceItems { get; set; }
    }
}
