using FluentAssertions;
using software_craftsmanship.Lib.Sorting_Algorithms;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    [Collection("UnitTestFixtures")]
    public class SortingAlgorithmsShould
    {
        private ISort _sut;

        [Theory]
        [InlineData(new[]{1,2,3}, new []{1,2,3})]
        [InlineData(new[]{7,4,2}, new []{2,4,7})]
        [InlineData(new[]{5,7,90,3,2,22}, new []{2,3,5,7,22,90})]
        public void Return_An_Ordered_Integer_List_Using_BubbleSort(int [] input, int[] expected)
        {
           _sut = new BubbleSort();

            var result = _sut.ReturnSortedList(input);
            expected.Should().BeEquivalentTo(result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 7, 4, 2 }, new[] { 2, 4, 7 })]
        [InlineData(new[] { 5, 7, 90, 3, 2, 22 }, new[] { 2, 3, 5, 7, 22, 90 })]
        public void Return_An_Ordered_Integer_List_Using_Selection(int[] input, int[] expected)
        {
            _sut = new SelectionSort();

            var result = _sut.ReturnSortedList(input);
            expected.Should().BeEquivalentTo(result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 7, 4, 2 }, new[] { 2, 4, 7 })]
        [InlineData(new[] { 5, 7, 90, 3, 2, 22 }, new[] { 2, 3, 5, 7, 22, 90 })]
        public void Return_An_Ordered_Integer_List_Using_QuickSort(int[] input, int[] expected)
        {
            _sut = new QuickSort();

            var result = _sut.ReturnSortedList(input);
            expected.Should().BeEquivalentTo(result);
        }
    }
}
