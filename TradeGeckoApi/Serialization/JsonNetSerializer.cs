using Newtonsoft.Json;
using RestSharp.Serializers;

namespace TradeGeckoApi.Serialization
{
    public class JsonNetSerializer : ISerializer
    {
        public JsonNetSerializer()
        {
            ContentType = "application/json";
        }

        public string ContentType { get; set; }
        public string DateFormat { get; set; }
        public string Namespace { get; set; }
        public string RootElement { get; set; }

        public string Serialize(object obj)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver(),
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(obj, settings);
        }
    }
}
