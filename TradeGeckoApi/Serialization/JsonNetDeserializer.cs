using Newtonsoft.Json;
using RestSharp;

namespace TradeGeckoApi.Serialization
{
    public class JsonNetDeserializer : RestSharp.Deserializers.IDeserializer
    {
        public string DateFormat { get; set; }
        public string Namespace { get; set; }
        public string RootElement { get; set; }

        public T Deserialize<T>(IRestResponse response)
        {
            var settings = new JsonSerializerSettings {ContractResolver = new ResponseContractResolver()};
            return JsonConvert.DeserializeObject<T>(response.Content, settings);
        }
    }
}
