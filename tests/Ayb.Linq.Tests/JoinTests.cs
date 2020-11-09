using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Tests.Data;
using Xunit;

namespace Ayb.Linq.Tests
{
    public class JoinTests
    {
        private readonly Join _join;

        public JoinTests()
        {
            _join = new Join();
        }

        [Fact]
        public void Join_GroupJoin()
        {
            // Arrange
            var products = FakeProduct.Data.Generate(5); // product's variants is null
            var variants = FakeVariant.Data.Generate(15);

            // Act
            var result = _join.GroupJoin(products, variants);

            // Assert
            Assert.True(result.All(x => x.Variants != null));
        }

        [Fact]
        public void Join_Join()
        {
            // Arrange
            var products = new List<string>{ "A", "B", "C"}; 
            var products2 = new List<string> { "A", "1", "2" };

            // Act
            var result = _join.ToJoin(products, products2);

            // Assert
            Assert.True(result.First() == "A");
        }
    }
}
