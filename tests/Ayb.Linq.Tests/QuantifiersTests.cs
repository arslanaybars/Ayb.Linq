using System.Linq;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class QuantifiersTests
    {
        private readonly Quantifiers _quantifiers;

        public QuantifiersTests()
        {
            _quantifiers = new Quantifiers();
        }

        [Fact]
        public void Quantifiers_All()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _quantifiers.All(products);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Quantifiers_Any()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _quantifiers.Any(products);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Quantifiers_Contains()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _quantifiers.Contains(products);

            // Assert
            Assert.True(result);
        }
    }
}
