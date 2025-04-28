using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.grades
{
    [Serializable]
    public class GradeScores
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }
        
    }
}
