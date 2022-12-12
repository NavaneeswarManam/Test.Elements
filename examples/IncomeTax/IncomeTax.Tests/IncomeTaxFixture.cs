using System;
using System.Collections.Generic;
using System.Text;
using TestElements.xUnit;
using Xunit;

namespace IncomeTax.Tests
{
    public class IncomeTaxFixture : IDisposable
    {
        public IncomeTaxFixture()
        {
            Id = 60;
        }

        public int Id { get; set; }

        public void Dispose()
        {
            Id = 0;
        }
    }
}
