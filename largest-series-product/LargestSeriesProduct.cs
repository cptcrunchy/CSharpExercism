using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism
{
    public static class LargestSeriesProduct
    {
        private static IEnumerable<int> Products(string digits, int span)
        {
            int chunk = digits.Count() - span + 1;
            var sections = Enumerable.Range(0, chunk);
            foreach( int section in sections)
            {
                yield return digits
                    .Substring(section, span)
                    .Select(c => (int)char.GetNumericValue(c))
                    .Aggregate(1, (a, b) => a * b);
            }
        }
        public static long GetLargestProduct(string digits, int span) 
        {
            if (span > digits.Length)
                throw new ArgumentException("span can't be larger than digits");
            if (span < 0)
                throw new ArgumentException("span can't be negative");
            if (!digits.All(c => char.IsDigit(c)))
                throw new ArgumentException("digits must be numeric");

            return Products(digits, span).Max();
        }
    }
}