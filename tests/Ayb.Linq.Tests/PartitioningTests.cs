using System.Collections.Generic;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class PartitioningTests
    {
        private readonly Partitioning _partitioning;

        public PartitioningTests()
        {
            _partitioning = new Partitioning();
        }

        [Fact]
        public void Partitioning_Skip()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _partitioning.Skip(products, 2);

            // Assert
            Assert.True(result.Count == 3);
        }

        [Fact]
        public void Partitioning_SkipWhile()
        {
            // Arrange
            List<string> words = new List<string>{ "one", "two", "three", "four", "five", "six" };

            // Act
            var result = _partitioning.SkipWhile(words);

            // Assert
            Assert.True(result.Count == 4);
        }


        [Fact]
        public void Partitioning_Take()
        {
            // Arrange
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var result = _partitioning.Take(numbers);

            // Assert
            Assert.True(result.Count == 2);
        }
    }
}
