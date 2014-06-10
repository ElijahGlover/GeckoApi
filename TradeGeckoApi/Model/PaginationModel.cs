using Newtonsoft.Json;

namespace TradeGeckoApi.Model
{
    public class PaginationModel
    {
        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("first_page")]
        public bool FirstPage { get; set; }

        [JsonProperty("last_page")]
        public bool LastPage { get; set; }

        [JsonProperty("out_of_bounds")]
        public bool OutOfBounds { get; set; }

        public int Offset { get; set; }
    }
}
