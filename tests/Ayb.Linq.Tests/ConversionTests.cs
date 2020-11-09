using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class ConversionTests
    {
        private readonly Conversion _conversion;

        public ConversionTests()
        {
            _conversion = new Conversion();
        }

        [Fact]
        public void Conversion_OfType()
        {
            // Arrange
            List<object> objects = new List<object>() { FakeProduct.Data.Generate(1), 7, "Kartal", FakeProduct.Data.Generate(1), null };

            // Act
            var result = _conversion.OfType(objects);

            // Assert
            Assert.True(result.Count() == 1);
        }

        [Fact]
        public void Conversion_ToDictionary()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _conversion.ToDictionary(products);

            // Assert
            Assert.True(result.Count(x => x.Value == "New") == 3);
        }

        [Fact]
        public void Conversion_ToLookup()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _conversion.ToLookup(products);

            // Assert
            Assert.True(result.Count() == 3);
        }
    }
}
