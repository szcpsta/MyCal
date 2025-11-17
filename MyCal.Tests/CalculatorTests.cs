
namespace MyCal.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            var cal = new Calculator();
            Assert.True(8 == cal.Add(3, 5));
        }

        [Fact]
        public void SubTest()
        {
            var cal = new Calculator();
            Assert.True(8 == cal.Sub(3, 5));
        }
    }
}
