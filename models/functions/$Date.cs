using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.functions
{
    public class DollarDate
    {
        [JsonProperty("$date")]
        public long? Date { get; set; }
        
    }
}
