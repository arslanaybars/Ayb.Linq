using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Conversion
    {
        public IEnumerable<string> OfType(List<object> objects)
        {
            return objects.OfType<string>();
        }

        public Dictionary<Product, string> ToDictionary(List<Product> products)
        {
            return products.ToDictionary(k => k, v => v.Id > 2 ? "New" : "Old");
        }

        public IEnumerable<Product> ToLookup(List<Product> products)
        {
            return products.ToLookup(p => p.Category)["Football"];
        }
    }
}
