using System;
using Algorithms.MinMaxSums;

namespace Algorithms.Test
{
    public class MinMaxSumBuilder
    {
        public static Algorithms.MinMaxSums.MinMaxSum NewWithAllProps(int[] input)
        {
            return new Algorithms.MinMaxSums.MinMaxSum(input);
        }
    }
}

