using cat.itb.M6NF3EA3.models.functions;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.products
{
    [Serializable]
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }
    }
}
