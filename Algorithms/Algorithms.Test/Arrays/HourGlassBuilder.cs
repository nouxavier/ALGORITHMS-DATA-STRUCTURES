using System;
using Algorithms.Arrays;

namespace Algorithms.Test.Arrays
{
    public class HourGlassBuilder
    {
        public static HourGlass NewWithAllProps(int[,] input)
        {
            return new HourGlass(input);
        }
    }
}

