using Xunit;
using SimpleApp;

namespace SimpleApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            var calc = new Calculator();
            Assert.Equal(6, calc.Multiply(2, 3));
        }
    }
}