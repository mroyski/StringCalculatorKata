using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator underTest;

        public StringCalculatorTests()
        {
            underTest = new StringCalculator();
        }

        [Fact]
        public void Add_Returns_0_For_Empty_String()
        {
            var result = underTest.Add("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_Returns_1_For_1()
        {
            var result = underTest.Add("1");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Add_Returns_2_For_2()
        {
            var result = underTest.Add("2");

            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void Add_Returns_Expected_Output(string input, int expected)
        {
            var result = underTest.Add(input);

            Assert.Equal(expected, result);
        }
    }
}
