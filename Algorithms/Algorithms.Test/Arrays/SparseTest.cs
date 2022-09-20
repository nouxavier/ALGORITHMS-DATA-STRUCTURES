using System;
using Algorithms.Arrays;
using ExpectedObjects;

namespace Algorithms.Test.Arrays
{
    public class SparceTest
    {
        private readonly string[] _strings;
        private readonly string[] _queries;
        public SparceTest()
        {
            _strings = new string[] { "ab", "ab", "abc" };
            _queries = new string[] { "ab", "abc", "bc" };
        }
        [Fact]
        public void CanCreateArr()
        {
            var arrExpected = new
            {
                StringList = _strings,
                Queries = _queries
            };

            var arr = new Sparse(arrExpected.StringList, arrExpected.Queries);

            arrExpected.ToExpectedObject().ShouldMatch(arr);
        }

        [Fact]
        public void ContainsSuccess()
        {
            var result = SparceBuilder.SparseBuilder(_strings, _queries).Contains();
            Assert.Equal(new int[] { 2, 1, 0 }, result);
        }
    }
}

