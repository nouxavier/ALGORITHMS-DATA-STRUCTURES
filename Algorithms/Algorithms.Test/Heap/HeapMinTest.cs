using System;
using Algorithms.Heap;
using Algorithms.Test.Arrays;
using Microsoft.VisualBasic;

namespace Algorithms.Test.HeapTest
{
    public class HeapMinTest
    {
        public HeapMinTest()
        {
           
        }

        [Fact]
        public void HeapMinSuccess()
        {
            HeapMin heap = new HeapMin(2);
            heap.InsertHeapMin(9);
            heap.InsertHeapMin(4);

            heap.Remove();
            Assert.Equal(new int[]{ 4, 9}, heap.Heap);
        }
    }
}

