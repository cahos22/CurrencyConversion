using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConversion.Models
{
    public class Currency
    {
        public byte Id { get; set; }

        public string Symbol { get; set; }
        public string Name { get; set; }
    }
}
