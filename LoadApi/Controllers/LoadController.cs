using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoadApi.Interfaces;

namespace LoadApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoadController : ControllerBase
    {
        private readonly ILogger<LoadController> _logger;

        private readonly IDbService _dbService;

        public LoadController(ILogger<LoadController> logger, IDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                string[] symbols = _dbService.Load();

                return symbols != null ? Ok(_dbService.Load()) : NoContent();
            }
            catch(Exception ex)
            {
                // log exceptions
                _logger.LogError(ex.Message, ex);

                // return 
                return StatusCode(500);
            }
        }
    }
}
