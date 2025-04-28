using cat.itb.M6NF3EA3.models.functions;
using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.students
{
    [Serializable]
    public class Student
    {
        [JsonProperty("_id")]
        public DollarOID Id { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname1")]
        public string LastName1 { get; set; }

        [JsonProperty("lastname2")]
        public string LastName2 { get; set; }

        [JsonProperty("dni")]
        public string Dni { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phone_aux")]
        public string PhoneAux { get; set; }

        [JsonProperty("birth_year")]
        public int BirthYear { get; set; }
    }
}
