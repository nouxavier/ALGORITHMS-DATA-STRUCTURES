using System;
using Algorithms.Exceptions;
using Algorithms.Ratios;
using ExpectedObjects;

namespace Algorithms.Test.Ratios
{
    public class RatioArrayTest
    {
        private readonly int[] _input;

        public RatioArrayTest()
        {
            _input = new int[] { 1, 1, 0, -1, -1 };
        }

        [Fact]
        public void CanCreateRatiosArray()
        {
            var ratioArrayExpected = new
            {
                Input = _input,
            };

            var ratioArray = new RatioArray(ratioArrayExpected.Input);

            ratioArrayExpected.ToExpectedObject().ShouldMatch(ratioArray);
        }

        [Theory]
        [InlineData(null)]
        public void ResultRatioException(int[] input)
        {
            Assert.Throws<DomainException> (() => RatioBuilder.NewWithAllPropsBuilder(input));
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 0, -1, -1 })]
        public void ResultRatioSucess(int[] input)
        {
            Assert.Equal(new float[] { 0.4f, 0.4f, 0.2f }, RatioBuilder.NewWithAllPropsBuilder(input).ResultRatio()) ;
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 0, -1, -1 })]
        public void ResultRatioListSucess(int[] input)
        {
            Assert.Equal(new float[] { 0.4f, 0.4f, 0.2f }, RatioBuilder.NewWithAllPropsBuilder(input).ResultRatioList());
        }


        [Theory]
        [InlineData(new int[] { -4, 3, -9, 0, 4, 1 })]
        public void ResultRatio3Sucess(int[] input)
        {
            Assert.Equal(new float[3] { 0.500000f, 0.333333f, 0.166667f }, RatioBuilder.NewWithAllPropsBuilder(input).ResultRatioList());
        }
    }

}

