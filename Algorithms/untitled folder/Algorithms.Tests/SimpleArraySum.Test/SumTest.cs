using System;
using Algorithms.SimpleArraySum;
using ExpectedObjects;
using Xunit;

namespace Algorithms.Tests.SimpleArraySum
{
    public class SumTest
    {
        private readonly int[] _input;
        public SumTest()
        {
            _input = new int[4] { 1, 1, 1, 1 };
        }


        [Fact]
        public void CanCreateSum()
        {
            var sumExpected = new
            {
                Input = _input,
            };

            var sum = new Sum(sumExpected.Input);

            sumExpected.ToExpectedObject().ShouldMatch(sum);
        }
    }
}
