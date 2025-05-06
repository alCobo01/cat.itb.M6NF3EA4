using cat.itb.M6NF3EA3.models.functions;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cat.itb.M6NF3EA3.models.restaurants
{
    [Serializable]
    public class RestaurantGrade
    {
        [JsonProperty("date")]
        [BsonElement("date")]
        public DollarDate Date { get; set; }

        [JsonProperty("grade")]
        [BsonElement("grade")]
        public string Grade { get; set; }

        [JsonProperty("score")]
        [BsonElement("score")]
        public int Score { get; set; }
    }
}
