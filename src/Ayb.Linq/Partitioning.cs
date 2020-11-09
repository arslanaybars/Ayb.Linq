using System.Collections.Generic;
using System.Linq;
using Ayb.Linq.Models;

namespace Ayb.Linq
{
    public class Partitioning
    {
        public List<Product> Skip(List<Product> source, int count)
        {
            return source.Skip(count).ToList();
        }

        public List<string> SkipWhile(List<string> source)
        {
            return source.SkipWhile(x => x.Length == 3).ToList();
        }

        public List<int> Take(List<int> source)
        {
            return source.Take(2).ToList();
        }
    }
}
