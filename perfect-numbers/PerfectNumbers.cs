using System;
using System.Linq;

namespace Excercism
{

    public enum Classification
    {
        Perfect,
        Abundant,
        Deficient
    }

    public static class PerfectNumbers
    {
        public static Classification Classify(int number)
        {
            if (number < 1) throw new ArgumentOutOfRangeException("Invalid number");

            int aliquotSum = AliquotSum(number);

            if (aliquotSum == number) return Classification.Perfect;

            return aliquotSum < number ? Classification.Deficient : Classification.Abundant;

        }

        private static int AliquotSum(int number) => Enumerable.Range(1, number - 1).Where(val => number % val == 0).Select(x => x).Sum();
    }

}