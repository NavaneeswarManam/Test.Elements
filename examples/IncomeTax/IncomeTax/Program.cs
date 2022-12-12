using IncomeTax.Calculator;
using IncomeTax.Income;
using IncomeTax.Models;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

namespace IncomeTax
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                        .AddScoped<ICalculatorService, CalculatorService>()
                        .AddScoped<IIncomeService, IncomeService>()
                        .BuildServiceProvider();

            var incomeService = serviceProvider.GetService<IIncomeService>();
            var income = new IncomeInput
            {
                IncomeType = Models.Enums.IncomeType.Salary,
                Salary = 1000000
            };
            var taxDetails = incomeService.GetIncomeResponse(income);

            Console.WriteLine(JsonConvert.SerializeObject(taxDetails));

            Console.Read();
        }
    }
}
