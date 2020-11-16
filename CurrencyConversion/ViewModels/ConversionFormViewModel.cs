using CurrencyConversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConversion.ViewModels
{
    public class ConversionFormViewModel
    {
        public IEnumerable<Currency> Currencies { get; set; }

        public Conversion Conversion { get; set; }
    }
}
