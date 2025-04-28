using Newtonsoft.Json;

namespace cat.itb.M6NF3EA3.models.countries
{
    [Serializable]
    public class Country
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("topLevelDomain")]
        public string[]? TopLevelDomain { get; set; }

        [JsonProperty("alpha2code")]
        public string? Alpha2Code { get; set; }

        [JsonProperty("alpha3code")]
        public string? Alpha3Code { get; set; }

        [JsonProperty("callingCodes")]
        public string[]? CallingCodes { get; set; }

        [JsonProperty("capital")]
        public string? Capital { get; set; }

        [JsonProperty("altSpellings")]
        public string[]? AltSpellings { get; set; }

        [JsonProperty("region")]
        public string? Region { get; set; }

        [JsonProperty("subregion")]
        public string? Subregion { get; set; }

        [JsonProperty("population")]
        public int? Population { get; set; }

        [JsonProperty("latlng")]
        public double[]? LatLng { get; set; }

        [JsonProperty("demonym")]
        public string? Demonym { get; set; }

        [JsonProperty("area")]
        public double? Area { get; set; }

        [JsonProperty("gini")]
        public double? Gini { get; set; }

        [JsonProperty("timezones")]
        public string[]? Timezones { get; set; }

        [JsonProperty("borders")]
        public string[]? Borders { get; set; }

        [JsonProperty("nativeName")]
        public string? NativeName { get; set; }

        [JsonProperty("numericCode")]
        public int? NumericCode { get; set; }

        [JsonProperty("currencies")]
        public Currency[]? Currencies { get; set; }

        [JsonProperty("languages")]
        public Language[]? Languages { get; set; }

        [JsonProperty("translations")]
        public Dictionary<string, string>? Translations { get; set; }

        [JsonProperty("flag")]
        public string? Flag { get; set; }

        [JsonProperty("regionalBlocs")]
        public RegionalBloc[]? RegionalBlocs { get; set; }

        [JsonProperty("cioc")]
        public string? Cioc { get; set; }
    }
}
