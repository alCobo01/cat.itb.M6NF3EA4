using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.functions
{
    [Serializable]
    public class DollarDate
    {
        [JsonProperty("$date")]
        [BsonElement("date")]
        public long Date { get; set; }
    }
}
