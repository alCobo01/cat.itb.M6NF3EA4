using cat.itb.M6NF3EA3.models.functions;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.grades
{
    [Serializable]
    public class Grades
    {
        [JsonProperty("_id")]
        public DollarOID ID { get; set; }

        [JsonProperty("student_id")]
        public NumberInt StudentID { get; set; }

        [JsonProperty("grade")]
        public GradeScores[] Grade { get; set; }

        [JsonProperty("class_id")]
        public NumberInt ClassID { get; set; }

    }
}
