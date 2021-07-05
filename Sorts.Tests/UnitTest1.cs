using FluentAssertions;
using NUnit.Framework;

namespace Sorts.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new int[] {5, 4, 3, 2, 1};

            SortAlgorithms.SortAlgorithms<int>.BubbleSort(input);

            input.Should().BeEquivalentTo(new[] {1, 2, 3, 4, 5});
        }
    }
}