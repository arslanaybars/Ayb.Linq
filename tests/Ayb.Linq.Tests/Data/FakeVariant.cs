using Ayb.Linq.Models;
using Bogus;

namespace Ayb.Linq.Tests.Data
{
    public static class FakeVariant
    {
        public static Faker<Variant> Data
        {
            get
            {
                var variantId = 1;

                return new Faker<Variant>()
                    .RuleFor(p => p.Id, f => variantId++)
                    .RuleFor(p => p.Sku, f => f.Commerce.Ean13())
                    .RuleFor(p => p.ProductId, f => f.Random.Int(1,5));
            }
        }
    }
}
