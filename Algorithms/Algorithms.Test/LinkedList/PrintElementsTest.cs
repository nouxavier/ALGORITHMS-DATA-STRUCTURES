using System;
using Algorithms.LinkedList;
using Algorithms.Test.LinkedList;

namespace Algorithms.Test.Arrays
{
    public class PrintElementsTest
    {


        public PrintElementsTest()
        {

        }
        [Fact]
        public void InsertElementsSuccess()
        {

            int[] input = new int[] { 2, 16, 13 };
            var result = PrintElementsBuilder.NewBuilder();
            var value = result.InsertElements(input);
            result.Print(value.head);
            Assert.Equal(200, 0);
        }


    }
}

