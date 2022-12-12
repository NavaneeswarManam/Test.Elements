
using IncomeTax.Calculator;
using IncomeTax.Models;
using System;

namespace IncomeTax.Income
{
    public class IncomeService : IIncomeService
    {
        public readonly ICalculatorService _calculatorService;
        public IncomeService(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public IncomeResponse GetIncomeResponse(IncomeInput income)
        {
            if (income == null)
            {
                throw new NullReferenceException("income is empty");
            }

            var incomeTax = _calculatorService.CalculateTax(income.Salary);

            return new IncomeResponse
            {
                IncomeType = income.IncomeType,
                Salary = income.Salary,
                NetAmount = incomeTax.net,
                Tax = incomeTax.tax
            };
        }
    }
}
