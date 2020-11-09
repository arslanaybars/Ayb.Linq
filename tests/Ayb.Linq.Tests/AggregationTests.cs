using System;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class AggregationTests
    {
        private readonly Aggregation _aggregation;

        public AggregationTests()
        {
            _aggregation = new Aggregation();
        }

        [Fact]
        public void Aggregation_Average()
        {
            // Arrange
            var numbers = new int[] {10, 20, 30, 40, 50};

            // Act
            var result = _aggregation.Average(numbers);

            // Assert
            Assert.True(Math.Abs(result - 30.0) < 0.1);
        }

        [Fact]
        public void Aggregation_Max()
        {
            // Arrange
            var numbers = new int[] { 10, 20, 30, 40, 50 };

            // Act
            var result = _aggregation.Max(numbers);

            // Assert
            Assert.True(Math.Abs(result - 50.0) < 0.1);
        }

        [Fact]
        public void Aggregation_Min()
        {
            // Arrange
            var numbers = new int[] { 10, 20, 30, 40, 50 };

            // Act
            var result = _aggregation.Min(numbers);

            // Assert
            Assert.True(Math.Abs(result - 10.0) < 0.1);
        }

        [Fact]
        public void Aggregation_Sum()
        {
            // Arrange
            var numbers = new int[] { 10, 20, 30, 40, 50 };

            // Act
            var result = _aggregation.Sum(numbers);

            // Assert
            Assert.True(Math.Abs(result - 150.0) < 0.1);
        }
    }
}
