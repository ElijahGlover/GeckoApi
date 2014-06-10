using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("variants", "variant")]
    public class Variant
    {
        public int? Id { get; set; }
        [JsonProperty("product_id")]
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("reorder_point")]
        public decimal? ReorderPoint { get; set; }
        [JsonProperty("wholesale_price")]
        public decimal? WholesalePrice { get; set; }
        [JsonProperty("retail_price")]
        public decimal? RetailPrice { get; set; }
        [JsonProperty("cost_price")]
        public decimal? CostPrice { get; set; }
        public string Status { get; set; }
        public string Upc { get; set; }
        [JsonProperty("supplier_code")]
        public string SupplierCode { get; set; }
        [JsonProperty("manage_stock")]
        public bool? ManageStock { get; set; }
        [JsonProperty("max_online")]
        public int? MaxOnline { get; set; }
        [JsonProperty("keep_selling")]
        public bool? KeepSelling { get; set; }
        public bool? Taxable { get; set; }
        [JsonProperty("is_online")]
        public bool? IsOnline { get; set; }
        [JsonProperty("online_ordering")]
        public bool? OnlineOrdering { get; set; }
        public string Opt1 { get; set; }
        public string Opt2 { get; set; }
        public string Opt3 { get; set; }
        public bool? Position { get; set; }
        [JsonProperty("buy_price")]
        public decimal? BuyPrice { get; set; }
        [JsonProperty("last_cost_price")]
        public decimal? LastCostPrice { get; set; }
        [JsonProperty("stock_on_hand")]
        public decimal? StockOnHand { get; set; }
        [JsonProperty("committed_stock")]
        public decimal? CommittedStock { get; set; }
        [JsonProperty("moving_average_cost")]
        public decimal? MovingAverageCost { get; set; }
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("product_name")]
        public string ProductName { get; set; }
        [JsonProperty("product_status")]
        public string ProductStatus { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        public bool? Composite { get; set; }
        public bool? Sellable { get; set; }
        [JsonProperty("vendor_code")]
        public string VendorCode { get; set; }
        [JsonProperty("variant_prices")]
        public IList<VariantPrice> VariantPrices { get; set; }
        [JsonProperty("locations")]
        public IList<VariantLocation> Locations { get; set; }
        [JsonProperty("image_ids")]
        public int[] ImageIds { get; set; }
    }
}
