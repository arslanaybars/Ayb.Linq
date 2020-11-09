using System;
using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class ElementTests
    {
        private readonly Element _element;

        public ElementTests()
        {
            _element = new Element();
        }

        [Fact]
        public void Conversion_First()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _element.First(products, 1);

            // Assert
            Assert.True(result.Id == 1);
        }

        [Fact]
        public void Conversion_First_Should_Throw_Exception()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            Action act = () => _element.First(products, 17);

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void Conversion_FirstOrDefault()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _element.FirstOrDefault(products, 1);

            // Assert
            Assert.True(result.Id == 1);
        }

        [Fact]
        public void Conversion_FirstOrDefault_Should_Return_Default()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _element.FirstOrDefault(products, 17);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Conversion_Last()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _element.Last(products, "Football");

            // Assert
            Assert.True(result.Id == 5);
        }

        [Fact]
        public void Conversion_Last_Should_Throw_Exception()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            Action act = () => _element.Last(products, "X");

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void Conversion_LastOrDefault()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _element.LastOrDefault(products, "Football");

            // Assert
            Assert.True(result.Id == 5);
        }

        [Fact]
        public void Conversion_LastOrDefault_Should_Return_Default()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _element.LastOrDefault(products, "X");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Conversion_Single()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(3);

            // Act
            var result = _element.Single(products, "Basketball");

            // Assert
            Assert.True(result.Id == 2);
        }

        [Fact]
        public void Conversion_Single_Should_Throw_Exception1()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(3);

            // Act
            Action act = () => _element.Single(products, "X");

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void Conversion_Single_Should_Throw_Exception()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(3);

            // Act
            Action act = () => _element.Single(products, "Football");

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void Conversion_SingleOrDefault()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(3);

            // Act
            var result = _element.SingleOrDefault(products, "Basketball");

            // Assert
            Assert.True(result.Id == 2);
        }

        [Fact]
        public void Conversion_SingleOrDefault_Should_Return_Default()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(3);

            // Act
            var result = _element.SingleOrDefault(products, "X");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void Conversion_SingleOrDefault_Should_Throw_Exception()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(3);

            // Act
            Action act = () => _element.SingleOrDefault(products, "Football");

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }
    }
}
