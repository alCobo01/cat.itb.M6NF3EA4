using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.grades
{
    [Serializable]
    public class Score
    {
        [JsonProperty("$numberDouble")]
        public double ScoreValue { get; set; }
        
    }
}
