using System;
using Ayb.Linq.Models;
using Bogus;

namespace Ayb.Linq.Tests.Data
{
    public static class FakeProduct
    {
        public static Faker<Product> Data
        {
            get
            {
                var productId = 1;
                
                return new Faker<Product>()
                    .RuleFor(p => p.Id, f => productId++)
                    .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Stock, f => f.Random.Number(1, 10))
                    .RuleFor(p => p.Price, f => Convert.ToDecimal(f.Commerce.Price()))
                    .RuleFor(p => p.Category, f => productId % 2 == 0 ? "Football" : "Basketball");
                    //.RuleFor(p => p.Variants, f => FakeVariant.Data.Generate(3))
            }
        }
    }
}
