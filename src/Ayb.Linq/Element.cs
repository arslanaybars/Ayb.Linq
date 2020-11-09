using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Element
    {
        public Product First(List<Product> products, int id)
        {
            return products.First(p => p.Id == id);
        }

        public Product FirstOrDefault(List<Product> products, int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Last(List<Product> products, string category)
        {
            return products.Last(p => p.Category == category);
        }

        public Product LastOrDefault(List<Product> products, string category)
        {
            return products.LastOrDefault(p => p.Category == category);
        }

        public Product Single(List<Product> products, string category)
        {
            return products.Single(p => p.Category == category);
        }

        public Product SingleOrDefault(List<Product> products, string category)
        {
            return products.SingleOrDefault(p => p.Category == category);
        }
    }
}
