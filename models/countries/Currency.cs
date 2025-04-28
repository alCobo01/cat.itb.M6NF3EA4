using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.countries
{
    [Serializable]
    public class Currency
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        
    }
}
