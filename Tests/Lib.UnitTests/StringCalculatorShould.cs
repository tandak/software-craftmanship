using FluentAssertions;
using software_craftsmanship.Lib.Katas;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    [Collection("UnitTestFixtures")]
    public class StringCalculatorShould
    {
        private readonly StringCalculator _sut;

        public StringCalculatorShould()
        {
            _sut = new StringCalculator();
        }

        [Theory]
        [InlineData("foo", "foo")]
        [InlineData("bar", "bar")]
        public void Return_String(string input, string expectedString)
        {
            var result = _sut.Add(input);

            result.Should().Be(expectedString);
        }
    }
}