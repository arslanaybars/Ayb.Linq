using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Quantifiers
    {
        public bool All(List<Product> products)
        {
            return products.All(p => p.Price > 0m);
        }

        public bool Any(List<Product> products)
        {
            return products.Any(p => p.Price > 0m);
        }

        public bool Contains(List<Product> products)
        {
            var firstProductName = products.First().Name;
            return products.Select(p => p.Name).Contains(firstProductName);
        }
    }
}
