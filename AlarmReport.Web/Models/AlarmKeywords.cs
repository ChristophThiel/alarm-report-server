namespace AlarmReport.Web.Models
{
    public class AlarmKeywords
    {
        public string FireAlarmIdentifier { get; set; }

        public string[] FireAlarmKeywords { get; set; }

        public string[] TechnicalAlarmKeywords { get; set; }

        public AlarmKeywords()
        {
            this.FireAlarmIdentifier = string.Empty;
            this.FireAlarmKeywords = new string[string.Empty.Length];
            this.TechnicalAlarmKeywords = new string[string.Empty.Length];
        }
    }
}
