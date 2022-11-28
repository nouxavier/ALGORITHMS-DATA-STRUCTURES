using System;
using Algorithms.Sort;

namespace Algorithms.Test.Sort
{
    public class SelectionSortTest
    {
        public SelectionSortTest()
        {
        }
        [Fact]
        public void SelectionCrescentSuccess()
        {
            List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();
                
            Assert.Equal(expect, SelectionSort.SelectionCrescent(inputs));
        }

        [Fact]
        public void SelectionDescendingSuccess()
        {
            List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();
            expect.Reverse();

            Assert.Equal(expect, SelectionSort.SelectionDescending(inputs));
        }
    }
}

