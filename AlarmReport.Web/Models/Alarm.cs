using AlarmReport.Web.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AlarmReport.Web.Models
{
    public class Alarm
    {
        [JsonProperty("alarmKeyword")]
        public string AlarmKeyword { get; set; }

        [JsonProperty("isFireAlarmType")]
        public bool IsFireAlarmType { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("parish")]
        public string Parish { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        public Alarm()
        {
            this.AlarmKeyword = string.Empty;
            this.IsFireAlarmType = false;
            this.Street = string.Empty;
            this.Parish = string.Empty;
            this.District = string.Empty;
        }
    }
}
