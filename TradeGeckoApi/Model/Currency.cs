using TradeGeckoApi.Serialization;

namespace TradeGeckoApi.Model
{
    [RootPropertyName("currencies", "currency")]
    public class Currency
    {
        public int? Id { get; set; }
        public string Iso { get; set; }
        public string Name { get; set; }
        public string Rate { get; set; }
        public string Symbol { get; set; }
        public string Seperator { get; set; }
        public string Delimiter { get; set; }
	    public int Precision { get; set; }
        public string Format { get; set; }
    }
}
