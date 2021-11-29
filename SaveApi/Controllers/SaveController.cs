using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SaveApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaveController : ControllerBase
    {
        private readonly ILogger<SaveController> _logger;

        public SaveController(ILogger<SaveController> logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public void Put(string[] symbols)
        {
            
        }
    }
}
