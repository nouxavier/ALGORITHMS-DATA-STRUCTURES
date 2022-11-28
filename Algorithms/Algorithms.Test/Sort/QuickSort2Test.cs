using System;
using Algorithms.Sort;

namespace Algorithms.Test.Sort
{
    public class QuickSort2Test
    {
        public QuickSort2Test()
        {
        }

        [Fact]
        public void SortCrescentSuccess()
        {
            List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();
          //  var teste = QuickSort2.Sort(inputs, 0, inputs.Count - 1);
           // Assert.Equal(expect, QuickSort2.Sort(inputs, 0, inputs.Count -1));
        }

        [Fact]
        public void SortCrescent2Success()
        {
            List<int> inputs = new List<int> { 4,3,2,1};
            var expect = new List<int> { 1,2,3,4};
            expect.Sort();
            List<int> inputs2;
            int a, b,c;
            (inputs2, a)= QuickSort2.Sort(inputs, 0, inputs.Count - 1);
           // Assert.Equal(expect, QuickSort2.Sort(inputs, 0, inputs.Count - 1));
        }

    }
}

