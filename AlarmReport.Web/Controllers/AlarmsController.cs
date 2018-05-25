using AlarmReport.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlarmReport.Web.Controllers
{
    [Route("api/[controller]")]
    public class AlarmsController : Controller
    {
        [HttpGet]
        public Alarm Get()
        {
            return new Alarm("Brandmeldealarm");
        }
    }
}