using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.restaurants
{
    [Serializable]
    public class Address
    {
        [JsonProperty("building")]
        [BsonElement("building")]
        public string Building { get; set; }

        [JsonProperty("coord")]
        [BsonElement("coord")]
        public double[] Coord { get; set; }

        [JsonProperty("street")]
        [BsonElement("street")]
        public string Street { get; set; }

        [JsonProperty("zipcode")]
        [BsonElement("zipcode")]
        public int Zipcode { get; set; }
    }
}
