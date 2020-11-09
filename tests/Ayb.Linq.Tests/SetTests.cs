using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class SetTests
    {
        private readonly Set _set;

        public SetTests()
        {
            _set = new Set();
        }

        [Fact]
        public void Set_Distinct()
        {
            // Arrange
            List<int> numbers = new List<int> { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            // Act
            var result = _set.Distinct(numbers);

            // Assert
            Assert.True(result.Count() == 7);
        }

        [Fact]
        public void Set_Except()
        {
            // Arrange
            List<int> numbers = new List<int> { 1, 2, 3 };
            List<int> numbers2 = new List<int> { 3, 4, 5 };

            // Act
            var result = _set.Except(numbers, numbers2);

            // Assert
            Assert.True(result.Count() == 2);
        }

        [Fact]
        public void Set_Intersect()
        {  
            // Arrange
            List<int> numbers = new List<int> { 1, 2, 3 };
            List<int> numbers2 = new List<int> { 3, 4, 5 };

            // Act
            var result = _set.Intersect(numbers, numbers2);

            // Assert
            Assert.True(result.Count() == 1);
        }

        [Fact]
        public void Set_Union()
        {
            // Arrange
            List<int> numbers = new List<int> { 1, 2, 3 };
            List<int> numbers2 = new List<int> { 3, 4, 5 };

            // Act
            var result = _set.Union(numbers, numbers2);

            // Assert
            Assert.True(result.Count() == 5);
        }
    }
}
