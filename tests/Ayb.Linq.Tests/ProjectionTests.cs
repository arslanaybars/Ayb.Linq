using System;
using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class ProjectionTests
    {
        private readonly Projection _projection;

        public ProjectionTests()
        {
            _projection = new Projection();
        }

        [Fact]
        public void Projection_Select()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _projection.Select(products);

            // Assert
            var obj = result.First();
            Assert.NotNull(obj.GetType()?.GetProperty("ProductName")?.GetValue(obj, null));
        }

        [Fact]
        public void Projection_SelectMany()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(1);
            products.First().Variants = new List<Variant>
            {
                new Variant
                {
                    Sku = "abc",
                    ProductId = 1,
                    Id = 10
                },
                new Variant
                {
                    Sku = "xyz",
                    ProductId = 1,
                    Id = 11
                }
            };

            // Act
            var result = _projection.SelectMany(products);

            // Assert
            Assert.IsType<Variant>(result.First());
        }
    }
}
