using System;
using Algorithms.Sort;

namespace Algorithms.Test.Sort
{
    public class MergeSortTest
    {
        public MergeSortTest()
        {
        }

        [Fact]
        public void SortCrescentSuccess()
        {
            List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();

            Assert.Equal(expect, MergeSort.SortCrescent(inputs, 0, inputs.Count));
        }
    }
}

