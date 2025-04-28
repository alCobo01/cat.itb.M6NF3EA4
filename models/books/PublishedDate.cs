using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.books
{
    [Serializable]
    public class PublishedDate
    {
        [JsonProperty("$date")]
        public string Date { get; set; }

        public override string ToString()
        {
            return
                "PublishedDate{" +
                "$date = '" + Date + '\'' +
                "}";
        }
    }
}
