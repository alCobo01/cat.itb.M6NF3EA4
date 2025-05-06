using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.countries
{
    [Serializable]
    public class Currency
    {
        [JsonProperty("code")]
        [BsonElement("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        [BsonElement("symbol")]
        public string Symbol { get; set; }
    }
}
