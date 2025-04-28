using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.countries
{
    [Serializable]
    public class RegionalBloc
    {
        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("otherAcronyms")]
        public string[] OtherAcronyms { get; set; }

        [JsonProperty("otherNames")]
        public string[] OtherNames { get; set; }
    }
}
