using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.functions
{
    [Serializable]
    public class DollarOID
    {
        [JsonProperty("$oid")]
        public string? OID { get; set; }
    }
}
