using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.restaurants
{
    [Serializable]
    public class Address
    {
        [JsonProperty("building")]
        public string? Building { get; set; }

        [JsonProperty("coord")]
        public string[]? Coord { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("zipcode")]
        public int ZipCode { get; set; }
    }
}
