using cat.itb.M6NF3EA3.models.functions;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.products
{
    [Serializable]
    public class Product
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [JsonProperty("name")]
        [BsonElement("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        [BsonElement("price")]
        public int Price { get; set; }

        [JsonProperty("stock")]
        [BsonElement("stock")]
        public int Stock { get; set; }

        [JsonProperty("picture")]
        [BsonElement("picture")]
        public string Picture { get; set; }

        [JsonProperty("categories")]
        [BsonElement("categories")]
        public List<string> Categories { get; set; }
    }
}
