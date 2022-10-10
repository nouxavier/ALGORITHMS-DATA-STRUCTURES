using System;
using Algorithms.Search;
using ExpectedObjects;

namespace Algorithms.Test.Search
{
    public class HackerlandRadioTransmittersTest
    {
        public HackerlandRadioTransmittersTest()
        {
        }

        [Fact]
        public void InstallRadio()
        {
            List<int> input = new List<int> { 7, 2, 4, 6, 5, 9, 12, 11 };
            int k = 2;
            var output = HackerlandRadioTransmitters.InstallRadio(input, k);
            Assert.Equal(3, output);

        }
    }
}

