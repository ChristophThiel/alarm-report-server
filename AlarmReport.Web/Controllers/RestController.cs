using Microsoft.AspNetCore.Mvc;
using AlarmReport.Web.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using System.Text;

namespace AlarmReport.Web.Controllers
{
    [Route("api/[controller]")]
    public class RestController : Controller
    {
        [HttpPost]
        [Route("alarm/pdf")]
        [EnableCors("AllowSpecificOrigin")]
        public string GeneratePdf([FromBody] Alarm alarm)
        {
            return JsonConvert.SerializeObject(alarm == null ? $"Error in {GetType().Name}: alarm cannot be null!" : "Pdf successful generated!");
        }
    }
}