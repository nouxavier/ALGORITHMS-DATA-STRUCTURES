using System;
using Algorithms.Hashs;

namespace Algorithms.Test.Hash
{
    public class LongSubstringTest
    {
        public LongSubstringTest()
        {
        }


        [Theory]
        [InlineData("aaabbcc", 3)]
        [InlineData("pwwkew", 4)]
        public void Length(string input, int output)
        {
            var total = LongSubstring.LengthOfLongSubstring(input);

            Assert.Equal(output, total);

        }
    }
}

