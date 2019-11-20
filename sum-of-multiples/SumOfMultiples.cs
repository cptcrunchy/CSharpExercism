using System.Collections.Generic;
using System.Linq;

namespace Exercism
{
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max) => 
            Enumerable.Range(1, max - 1)
            .Where(number => multiples.Any( multiple => multiple != 0 && number % multiple == 0))
            .Sum();

    }
}