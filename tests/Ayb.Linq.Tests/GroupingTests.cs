using System.Linq;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class GroupingTests
    {
        private readonly Grouping _grouping;

        public GroupingTests()
        {
            _grouping = new Grouping();
        }

        [Fact]
        public void Grouping_GroupBy()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5);

            // Act
            var result = _grouping.GroupBy(products);

            // see projection
            var allFootballProducts = result.Where(x => x.Key).SelectMany(x => x);
            var allBasketballProducts = result.Where(x => !x.Key).SelectMany(x => x);
            
            // Assert
            Assert.True(allFootballProducts.All(x => x.Category == "Football"));
            Assert.True(allBasketballProducts.All(x => x.Category == "Basketball"));
        }
    }
}
