using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.countries
{
    [Serializable]
    public class Language
    {
        [JsonProperty("iso639_1")]
        [BsonElement("iso639_1")]
        public string Iso639_1 { get; set; }

        [JsonProperty("iso639_2")]
        [BsonElement("iso639_2")]
        public string Iso639_2 { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        [JsonProperty("nativeName")]
        [BsonElement("nativeName")]
        public string NativeName { get; set; }
    }
}
