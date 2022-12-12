
using IncomeTax.Models;

namespace IncomeTax.Income
{
    public interface IIncomeService
    {
        IncomeResponse GetIncomeResponse(IncomeInput income);
    }
}
