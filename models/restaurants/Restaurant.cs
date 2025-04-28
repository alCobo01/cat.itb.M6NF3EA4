using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.restaurants
{
    [Serializable]
    public class Restaurant
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("borough")]
        public string Borough { get; set; }

        [JsonProperty("cuisine")]
        public string Cuisine { get; set; }

        [JsonProperty("grades")]
        public RestaurantGrades[] Grades { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("restaurant_id")]
        public string RestaurantId { get; set; }
    }
}
