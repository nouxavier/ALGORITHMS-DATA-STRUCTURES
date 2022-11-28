using System;
using Algorithms.Arrays;
using Algorithms.Search;

namespace Algorithms.Test.Search
{
    public class PairsTest
    {
        public PairsTest()
        {
        }
        [Fact]
        public void CountPairSuccess()
        {

            var input = new int[] { 1, 5, 3, 4, 2 };
            int k = 2;
            var result = Pairs.CountPairs(k, input);
            Assert.Equal(3, result);
        }
        [Fact]
        public void CountGoodSuccess()
        {

            var input = new int[] { 1, 2, 3, 4 };
            int k = 1;
            var result = Pairs.CountGood(k, input);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Count2GoodSuccess()
        {

            var input = new int[] { 1, 2, 3, 4, 5 };
            int k = 2;
            var result = Pairs.CountGood(k, input);
            Assert.Equal(3, result);
        }
    }
}

