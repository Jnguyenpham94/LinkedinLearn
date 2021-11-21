using CalculatorApp;
using System;
using Xunit;

namespace calculatorApp.test
{
    public class MathHelperTest
    {
        [Fact]
        public void isEvenTest()
        {
            var calculator = new MathFormulas();

            int x = 1;
            int y = 2;

            var xResult = calculator.IsEven(x);
            var yResult = calculator.IsEven(y);

            Assert.False(xResult);
            Assert.True(yResult);
        }

        [Theory]
        [InlineData(1,2,1)]
        [InlineData(1, 3, 2)]
        public void diffTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Diff(x, y);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] {1,2,3}, 6)]
        [InlineData(new int[3] {-4,-6,10}, 0)]
        public void sumTest(int[] values, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Sum(values);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        public void addTest(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[3] { 1, 2, 3 }, 2)]
        [InlineData(new int[3] { 20, -6, 10 }, 8)]
        public void averageTest(int[] values, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Average(values);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(MathFormulas.Data), MemberType = typeof(MathFormulas))]
        public void Add_MemberData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }

        [Theory(Skip ="This is just the reason...")]
        [ClassData(typeof(MathFormulas))]
        public void Add_ClassData_Test(int x, int y, int expectedValue)
        {
            var calculator = new MathFormulas();
            var result = calculator.Add(x, y);
            Assert.Equal(expectedValue, result);
        }
    }
}
