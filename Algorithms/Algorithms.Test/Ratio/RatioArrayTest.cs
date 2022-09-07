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
        [InlineData(new int[] { -76, -33, 0, -37, 39, 0, 33, -10, 0, 57, 59, 0, -14 - 57, 0, -96, 45, 0, -60, 82, 0, -94, -31, 0, -68, -53, 0, -57, 100, 0, 35, 81, 0, -4, 76, 0, 15, 60, 0, 2, -85, 0, 16, -70, 0, 62, -25, 0, 4, -89, 0, -79, -80, 0, -23, 97, 0, 69, -68, 0, -83, -57, 0, 74, 1, 0, -66, 23, 0, 68, -80, 0, 100, 10, 0, -73, -54, 0, 0, 4, 0, -8, -86, 0, 58, -85, 0, -100, -100, 0, 43, 61, 0, 61, -86, 0, 24, -95, 0, -54 })]
        public void ResultRatio2Sucess(int[] input)
        {

            Assert.Equal(new float[] { 0.300000f, 0.360000f, 0.340000f }, RatioBuilder.NewWithAllPropsBuilder(input).ResultRatio());
        }

        [Theory]
        [InlineData(new int[] { -4, 3, -9, 0, 4, 1 })]
        public void ResultRatio3Sucess(int[] input)
        {
            Assert.Equal(new float[3] { 0.500000f, 0.333333f, 0.166667f }, RatioBuilder.NewWithAllPropsBuilder(input).ResultRatioList());
        }
    }

}

