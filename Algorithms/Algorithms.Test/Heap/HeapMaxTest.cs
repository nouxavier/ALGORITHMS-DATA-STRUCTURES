using System;
using Algorithms.Heap;
using Algorithms.Test.Arrays;
using Microsoft.VisualBasic;

namespace Algorithms.Test.HeapTest
{
    public class HeapMaxTest
    {
        public HeapMaxTest()
        {
           
        }

        [Fact]
        public void HeapMaxSuccess()
        {
            HeapMax heap = new HeapMax(2);
            heap.InsertHeapMax(4);
            heap.InsertHeapMax(9);


            heap.Remove();
            heap.BuildHeap();

            Assert.Equal(new int[]{ 9,4}, heap.Heap);
        }
    }
}

