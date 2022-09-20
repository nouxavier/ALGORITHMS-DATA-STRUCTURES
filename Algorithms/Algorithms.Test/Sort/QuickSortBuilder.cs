using System;
using Algorithms.Sort;

namespace Algorithms.Test.Sort
{
    public class QuickSortBuilder
    {
        public static QuickSort NewAllProps(int[] input)
        {
            return new QuickSort(input);
        }
    }
}
