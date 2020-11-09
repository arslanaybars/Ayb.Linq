using System.Linq;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class RestrictionTests
    {
        private readonly Restriction _restriction;

        public RestrictionTests()
        {
            _restriction = new Restriction();
        }

        [Fact]
        public void Restriction_Where()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);
            
            // Act
            var result = _restriction.Where(products);

            // Assert
            Assert.True(result.Count() == 5);
        }
    }
}
