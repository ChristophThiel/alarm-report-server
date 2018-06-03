using Microsoft.AspNetCore.Mvc;
using AlarmReport.Web.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using System.Text;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;

namespace AlarmReport.Web.Controllers
{
    [Route("api/[controller]")]
    public class AlarmKeywordController : Controller
    {
        private readonly IHostingEnvironment _environment;
        public AlarmKeywordController(IHostingEnvironment environment)
        {
            this._environment = environment;
        }
        
        [HttpGet]
        [EnableCors("AllowSpecificOrigin")]
        public ContentResult GetAlarmKeywords() => this.Content(System.IO.File.ReadAllText(Path.Combine(this._environment.WebRootPath, "json", "AlarmKeywords.json")), "application/json");
    }
}