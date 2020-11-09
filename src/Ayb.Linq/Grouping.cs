using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Grouping
    {
        public IEnumerable<IGrouping<bool, Product>> GroupBy(List<Product> products)
        {
            return products.GroupBy(x => x.Category == "Football");
        }
    }
}
