using cat.itb.M6NF3EA3.models.functions;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.restaurants
{
    [Serializable]
    public class RestaurantGrades
    {
        [JsonProperty("date")]
        public DollarDate Date { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

    }
}
