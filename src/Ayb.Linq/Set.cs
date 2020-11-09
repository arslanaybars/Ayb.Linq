using System.Collections.Generic;
using System.Linq;

namespace Ayb.Linq
{
    public class Set
    {
        public IEnumerable<int> Distinct(List<int> numbers)
        {
            return numbers.Distinct();
        }

        public IEnumerable<int> Except(List<int> numbers, List<int> numbers2)
        {
            return numbers.Except(numbers2);
        }

        public IEnumerable<int> Intersect(List<int> numbers, List<int> numbers2)
        {
            return numbers.Intersect(numbers2);
        }

        public IEnumerable<int> Union(List<int> numbers, List<int> numbers2)
        {
            return numbers.Union(numbers2);
        }
    }
}
