
namespace IncomeTax.Models
{
    public class IncomeResponse : IncomeInput
    {
        public decimal Tax { get; set; }
        public decimal NetAmount { get; set; }
    }
}
