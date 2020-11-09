using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Projection
    {
        public IEnumerable<object> Select(List<Product> products)
        {
            // Anonymous usage. you can convert into strongly typed object
            return products.Select(x => new { ProductName = x.Name, Price = x.Price });
        }

        public IEnumerable<Variant> SelectMany(List<Product> products)
        {
            // direk olarak variantlarin ienumerable'ye alinmasi
            return products.SelectMany(p => p.Variants);

            // list of list bazinda variantlarin alinmasi
            IEnumerable<IEnumerable<Variant>> variants = products.Select(p => p.Variants);

            // join yapilan data ile birlikte anonymous bir ienumerable<obj> yaratmak
            var anonEnumerable = products
                .SelectMany(p => p.Variants,
                    (p, v) => new { p.Name, v.Sku });
        }
    }
}
