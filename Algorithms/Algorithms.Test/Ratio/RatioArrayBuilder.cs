using System;
using Algorithms.Ratios;

namespace Algorithms.Test.Ratios
{
    public class RatioBuilder
    {
        public static RatioArray NewWithAllPropsBuilder(int[] input)
        {
            return new RatioArray(input);
        }
    }
}

