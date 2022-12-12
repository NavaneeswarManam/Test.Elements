
namespace IncomeTax.Calculator
{
    public interface ICalculatorService
    {
        (decimal tax, decimal net) CalculateTax(decimal amount);
    }
}
