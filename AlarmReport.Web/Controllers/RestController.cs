using Microsoft.AspNetCore.Mvc;
using AlarmReport.Web.Models;
using Newtonsoft.Json;

namespace AlarmReport.Web.Controllers
{
    [Route("api/[controller]")]
    public class RestController : Controller
    {
        [HttpPost]
        [Route("alarm/pdf")]
        public string GeneratePdf([FromBody] Alarm alarm)
        {
            var json = JsonConvert.SerializeObject(alarm);
            return alarm == null ? $"Error in {GetType().Name}: alarm cannot be null!" : "Pdf successful generated!";
        }
    }
}