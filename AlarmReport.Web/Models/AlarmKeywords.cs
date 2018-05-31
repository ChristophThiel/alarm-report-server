using Newtonsoft.Json;

namespace AlarmReport.Web.Models
{
    public class AlarmKeywords
    {
        [JsonProperty("fireAlarmIdentifier")]
        public string FireAlarmIdentifier { get; set; }

        [JsonProperty("fireAlarmKeywords")]
        public string[] FireAlarmKeywords { get; set; }

        [JsonProperty("technicalAlarmKeywords")]
        public string[] TechnicalAlarmKeywords { get; set; }

        public AlarmKeywords()
        {
            this.FireAlarmIdentifier = string.Empty;
            this.FireAlarmKeywords = new string[string.Empty.Length];
            this.TechnicalAlarmKeywords = new string[string.Empty.Length];
        }
    }
}
