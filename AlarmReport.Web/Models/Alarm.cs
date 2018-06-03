using System.ComponentModel.DataAnnotations.Schema;
using AlarmReport.Web.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AlarmReport.Web.Models
{
    public class Alarm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        
        public string AlarmKeyword { get; set; }
        public bool IsFireAlarmType { get; set; }
        public string Street { get; set; }
        public string Parish { get; set; }
        public string District { get; set; }

        public Alarm()
        {
            
        }
    }
}
