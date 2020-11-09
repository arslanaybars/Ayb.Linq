using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Restriction
    {
        public IEnumerable<Product> Where(List<Product> products)
        {
            return products.Where(p => p.Price > 0m);
        }
    }
}
