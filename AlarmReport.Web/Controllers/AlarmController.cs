using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AlarmReport.Web.Manager;
using Microsoft.AspNetCore.Mvc;

namespace AlarmReport.Web.Controllers
{
    [Route("api/[controller]")]
    public class AlarmController : Controller
    {
        private readonly DatabaseContext _context;
        public AlarmController(DatabaseContext context)
        {
            this._context = context;
        }
        
        [HttpGet]
        public ContentResult Get()
        {
            throw new NotImplementedException();
        }
    }
}