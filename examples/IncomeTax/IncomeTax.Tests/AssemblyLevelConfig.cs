using IncomeTax.Tests;
using TestElements.xUnit;
using Xunit;


[assembly: TestFramework("TestElements.xUnit.Sdk.XunitTestFrameworkWithAssemblyFixture","TestElements.xUnit")]
[assembly: AssemblyFixture(typeof(IncomeTaxFixture))] 