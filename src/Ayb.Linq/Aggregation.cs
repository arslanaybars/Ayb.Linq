using System.Linq;

namespace Ayb.Linq
{
    public class Aggregation
    {
        public double Average(int[] numbers)
        {
            return numbers.Average();
        }

        public double Max(int[] numbers)
        {
            return numbers.Max();
        }

        public double Min(int[] numbers)
        {
            return numbers.Min();
        }

        public double Sum(int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
