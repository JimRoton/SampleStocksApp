using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StocksApi.Models;

namespace StocksApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StocksApi : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<StocksApi> _logger;

        public StocksApi(ILogger<StocksApi> logger)
        {
            _logger = logger;
        }

        [HttpGet("{symbol}")]
        public Stock Get()
        {
            return new Stock();
        }
    }
}
