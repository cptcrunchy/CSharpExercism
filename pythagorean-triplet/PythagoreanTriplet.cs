using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism
{
    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int sideA, int sideB, int sideC)> TripletsWithSum(int sum)
        {
            if(sum <= 5)
                throw new ArgumentException("The sum must be greater than 5.");

            return Enumerable
                   .Range(1, sum - 1)
                   .SelectMany(
                        a => Enumerable.Range(a + 1, sum - a - 1)
                        .Where(b => b < C(a, b, sum) && IsValid(a,b, C(a, b, sum)))
                        .Select(b => new ValueTuple<int, int, int>(a, b, C(a, b, sum))));
        }

        private static int C(int a, int b, int sum) => sum - a - b;
        private static bool IsValid(int a, int b, int c) => Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2);
    }
}