using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.people
{
    [Serializable]
    public class Friend
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

