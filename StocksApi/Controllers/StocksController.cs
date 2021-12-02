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
        private readonly ILogger<StocksApi> _logger;

        public StocksApi(ILogger<StocksApi> logger)
        {
            _logger = logger;
        }

        [HttpGet("{symbol}")]
        public Stock Search()
        {
            return new Stock();
        }

        [HttpGet]
        public Stock[] Load()
        {
            return new Stock[]{
                new Stock(){
                    Name = "Microsoft",
                    Symbol = "MSFT",
                    Price = 1.00,
                    Source = "REDIS"
                }
            };
        }

        [HttpPut("{symbol}")]
        public void Save(string symbol)
        {

        }

        [HttpDelete("{symbol}")]
        public void Delete(string symbol)
        {

        }   
    }
}
