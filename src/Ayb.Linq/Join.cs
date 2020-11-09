using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Join
    {
        public IEnumerable<Product> GroupJoin(List<Product> products, List<Variant> variants)
        {
            return products.GroupJoin(variants, p => p.Id, v => v.ProductId, (product, variant) => new Product
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                Price = product.Price,
                Stock = product.Stock,
                Variants = variant.ToList()
            });
        }

        public IEnumerable<string> ToJoin(List<string> products, List<string> products2)
        {
            return products.Join(products2, p => p, pr => pr, (p, pr) => p);
        }
    }
}
