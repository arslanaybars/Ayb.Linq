using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class OrderingTests
    {
        private readonly Ordering _ordering;

        public OrderingTests()
        {
            _ordering = new Ordering();
        }

        [Fact]
        public void Ordering_OrderBy()
        {
            // Arrange
            var numbers = new List<int> { 13, 24, 5, 7, 17 };

            // Act
            var result = _ordering.OrderBy(numbers);

            // Assert
            Assert.True(result.First() == 5);
        }

        [Fact]
        public void Ordering_OrderByDescending()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _ordering.OrderByDescending(products);

            // Assert
            Assert.True(result.First().Id == 5);
        }

        [Fact]
        public void Ordering_Reverse()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _ordering.Reverse(products);

            // Assert
            Assert.True(result.First().Id == 3);
        }


        [Fact]
        public void Ordering_ThenBy()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _ordering.ThenBy(products);

            // Assert
            Assert.True(result.First().Id == 1);
        }


        [Fact]
        public void Ordering_ThenByDescending()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _ordering.ThenByDescending(products);

            // Assert
            Assert.True(result.First().Id == 5);
        }
    }
}
