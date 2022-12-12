using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IncomeTax.Tests
{
    public class Sample2Test
    {
        IncomeTaxFixture incomeTaxFixture;
        public Sample2Test(IncomeTaxFixture incomeTaxFixture)
        {
            this.incomeTaxFixture = incomeTaxFixture;
        }

        [Fact]
        public void ShouldEqual1()
        {
            Assert.Equal(60, this.incomeTaxFixture.Id);
        }

        [Fact]
        public void ShouldEqual2()
        {
            Assert.Equal(60, this.incomeTaxFixture.Id);
        }
    }
}
