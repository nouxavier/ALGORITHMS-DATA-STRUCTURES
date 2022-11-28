using System;
using Algorithms.Sort;

namespace Algorithms.Test.Sort
{
    public class BubbleSortTest
    {
        public BubbleSortTest()
        {
        }

        [Fact]
        public void SortCrescentSuccess()
        {
            List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();

            Assert.Equal(expect, BubbleSort.SortCrescent(inputs));
        }

        [Fact]
        public void SortDescendingSuccess()
        {
            List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();
            expect.Reverse();

            Assert.Equal(expect, BubbleSort.SortDescending(inputs));
        }


    }
}

