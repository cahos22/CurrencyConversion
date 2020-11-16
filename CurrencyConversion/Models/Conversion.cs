using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConversion.Models
{
    public class Conversion
    {
        public int Id { get; set; }
        public Currency FromCurrency { get; set; }

        public byte FromCurrencyId { get; set; }

        public Currency ToCurrency { get; set; }

        public byte ToCurrencyId { get; set; }

        public decimal Rate { get; set; }
    }
}
