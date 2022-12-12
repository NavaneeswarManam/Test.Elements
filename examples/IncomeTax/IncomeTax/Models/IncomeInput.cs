
using IncomeTax.Models.Enums;

namespace IncomeTax.Models
{
    public class IncomeInput
    {
        public decimal Salary { get; set; }
        public IncomeType IncomeType { get; set; }
    }
}
