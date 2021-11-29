using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoadApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoadController : ControllerBase
    {
        private readonly ILogger<LoadController> _logger;

        public LoadController(ILogger<LoadController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new String[]{
                "MSFT",
                "APPL",
                "BBY"
            };
        }
    }
}
