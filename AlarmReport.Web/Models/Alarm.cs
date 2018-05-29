using AlarmReport.Web.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AlarmReport.Web.Models
{
    public class Alarm
    {
        [JsonProperty("alarmKeyword")]
        public string AlarmKeyword { get; set; }

        public Alarm(string alarmKeyword)
        {
            this.AlarmKeyword = alarmKeyword;
        }
    }
}
