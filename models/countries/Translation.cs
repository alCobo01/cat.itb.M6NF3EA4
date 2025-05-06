using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA4.models.countries
{
    [Serializable]
    public class Translation
    {
        [JsonProperty("de")]
        [BsonElement("de")]
        public string De { get; set; }

        [JsonProperty("es")]
        [BsonElement("es")]
        public string Es { get; set; }

        [JsonProperty("fr")]
        [BsonElement("fr")]
        public string Fr { get; set; }

        [JsonProperty("ja")]
        [BsonElement("ja")]
        public string Ja { get; set; }

        [JsonProperty("it")]
        [BsonElement("it")]
        public string It { get; set; }

        [JsonProperty("br")]
        [BsonElement("br")]
        public string Br { get; set; }

        [JsonProperty("pt")]
        [BsonElement("pt")]
        public string Pt { get; set; }

        [BsonElement("nl")]
        [JsonProperty("nl")]
        public string Nl { get; set; }

        [BsonElement("hr")]
        [JsonProperty("hr")]
        public string Hr { get; set; }

        [JsonProperty("fa")]
        [BsonElement("fa")]
        public string Fa { get; set; }
    }
}
