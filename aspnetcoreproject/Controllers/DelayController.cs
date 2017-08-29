using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreloadtest.Controllers
{
    [Route("api/[controller]")]
    public class DelayController : Controller
    {
        [HttpGet]
        public async Task<string> Get()
        {
            await Task.Delay(1000);
            return "Awake!" ;
        }
    }
}
