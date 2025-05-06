using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.countries
{
    [Serializable]
    public class RegionalBloc
    {
        [JsonProperty("acronym")]
        [BsonElement("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        [JsonProperty("otherAcronyms")]
        [BsonElement("otherAcronyms")]
        public List<string> OtherAcronyms { get; set; }

        [JsonProperty("otherNames")]
        [BsonElement("otherNames")]
        public List<string> OtherNames { get; set; }
    }
}
