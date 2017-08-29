using System.Collections.Generic;
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
            var tasks = new List<Task>();
            for (var i = 0; i < 100; i++)
            {
                tasks.Add(Task.Run(async () => await Task.Delay(1000)));
            }

            Task.WaitAll(tasks.ToArray());

            return "Awake!" ;
        }
    }
}
