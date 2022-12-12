
using IncomeTax.Models;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace IncomeTax.Calculator
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IncomeTaxSlab incomeTaxSlab;
        public CalculatorService()
        {
            var taxSlabs = File.ReadAllText(Path.Combine("Calculator", "Data", "incomeTax.json"));
            incomeTaxSlab = JsonConvert.DeserializeObject<IncomeTaxSlab>(taxSlabs);
        }

        public (decimal tax, decimal net) CalculateTax(decimal amount)
        {
            if (amount <= 250000)
            {
                return (tax: 0, net: amount);
            }

            if (amount > 1500000)
            {
                return (tax: amount * 0.3m, net: amount - (amount * 0.3m));
            }

            var taxPercentage = incomeTaxSlab.Slabs.First(a => amount >= a.From && amount < a.To).TaxPercentage;

            return (tax: amount * taxPercentage, net: amount - (amount * taxPercentage)); ;
        }
    }
}
