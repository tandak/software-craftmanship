using FluentAssertions;
using software_craftsmanship.Lib;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    [Collection("UnitTestFixtures")]
    public class StringCalculatorShould
    {
        private StringCalculator _sut;

        public StringCalculatorShould()
        {
            _sut = new StringCalculator();
        }

        [Theory]
        [InlineData("foo", "foo2")]
        [InlineData("bar", "bar")]
        public void Return_String(string input, string expectedString)
        {
            var result = _sut.add(input);

            result.Should().Be(expectedString);
        }
    }
}
