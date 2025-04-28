using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.functions
{
    [Serializable]
    public class NumberInt
    {
        [JsonProperty("$numberInt")]
        public int Value { get; set; }
    }
}
