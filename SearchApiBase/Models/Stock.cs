using System;

namespace SearchApi.Models
{
    public class Stock
    {
        public DateTime Date { get; set; }

        public string Symbol { get; set; }

        public string Name  { get; set; }

        public double Price { get; set; }
    }
}
