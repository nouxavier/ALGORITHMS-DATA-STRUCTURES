using System;
using Algorithms.Arrays;

namespace Algorithms.Test.Arrays
{
    public class ArrayOfArrayProductsTest
    {
        public ArrayOfArrayProductsTest()
        {
        }

        [Fact]
        public void ProductSuccess()
        {

            var input = new int[] { -3, 17, 430, -6, 5, -12, -11, 5 };
            var expect = new long[] { -144738000, 25542000, 1009800, -72369000, 86842800, -36184500, -39474000, 86842800 };
            var result = ArrayOfArrayProducts.Product(input);
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Product2Success()
        {

            var input = new int[] { 2, 7, 3, 4 };
            var expect = new long[] { 84, 24, 56, 42 };
            var result = ArrayOfArrayProducts.ProductGood(input);
            Assert.Equal(expect, result);
        }
    }
}

