using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Ordering
    {
        public List<int> OrderBy(List<int> source)
        {
            return source.OrderBy(x => x).ToList();
        }

        public List<Product> OrderByDescending(List<Product> source)
        {
            return source.OrderByDescending(x => x.Id).ToList();
        }

        public List<Product> Reverse(List<Product> source)
        {
            source.Reverse(0, 3);
            return source;
        }
        public List<Product> ThenBy(List<Product> source)
        {
            return source.OrderBy(x => x.Id).ThenBy(x => x.Category).ToList();
        }
        public List<Product> ThenByDescending(List<Product> source)
        {
            return source.OrderByDescending(x => x.Id).ThenByDescending(x => x.Category).ToList();
        }
    }
}
