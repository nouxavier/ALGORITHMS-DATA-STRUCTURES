using System;
using Algorithms.Sum;

namespace Algorithms.Test.Sum
{
    public class BigSumBuilder
    {
        public static BigSum NewWithAllProps(long[] input)
        {
            return new BigSum(input);
        }
    }
}

