namespace AlarmReport.Web.Models
{
    public class Alarm
    {
        public string AlarmKeyword { get; set; }

        public Alarm(string alarmKeyword)
        {
            this.AlarmKeyword = alarmKeyword;
        }
    }
}
