using System;
using Algorithms.Sum;

namespace Algorithms.Test.Sum
{
    public class SimpleSumBuilder
    {
        public static SimpleSum NewWithAllProps(int[] input)
        {
            return new SimpleSum(input);
        }
    }
}

