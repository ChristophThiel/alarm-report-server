using Microsoft.AspNetCore.Mvc;
using AlarmReport.Web.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using System.Text;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Threading;

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
        public async Task<ContentResult> GetAlarmKeywords(CancellationToken cancellationToken)
        {
            return this.Content(await System.IO.File.ReadAllTextAsync(Path.Combine(this._environment.WebRootPath, "json", "AlarmKeywords.json"), cancellationToken), "application/json");
        }
    }
}