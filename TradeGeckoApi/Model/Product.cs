using Newtonsoft.Json;
using System;
using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("products", "product")]
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("product_type")]
        public string ProductType { get; set; }
        public string Supplier { get; set; }
        public string Brand { get; set; }
        public string Status { get; set; }
        public string Tags { get; set; }
        public string Opt1 { get; set; }
        public string Opt2 { get; set; }
        public string Opt3 { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("search_cache")]
        public string SearchCache { get; set; }
        [JsonProperty("variant_ids")]
        public int[] VariantIds { get; set; }
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
