using FluentAssertions;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    [Collection("UnitTestFixtures")]
    public class FooShould
    {
        [Fact]
        public void Return_True_When_Majority_Of_Sample_Is_Below_Threshold() 
        {
            var input = new[] {200, 500, 500, 70, 200, 190, 100, 200, 111, 123, 193, 147, 192, 92, 54};

            var sut = new Foo().ShouldDownscale(input);

            sut.Should().Be(true);
        }
    }

    public class Foo
    {
        public bool ShouldDownscale(int[] input)
        {
            int isLower = 0;
            foreach (var foo in input)
            {
                if (foo <= 200)
                {
                    isLower++;
                }
            }
            var result = ((double)isLower / 15)* 100;
            return result > 80;

        }
    }
}
