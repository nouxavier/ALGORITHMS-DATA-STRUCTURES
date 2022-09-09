using System;
namespace Algorithms.Test.Time
{
    public class TimeConvertTest
    {
        public TimeConvertTest()
        {
        }

        [Theory]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("07:05:45PM", "19:05:45")]
        public void ConvertTimeSucess(string input, string output)
        {
            Assert.Equal(output, TimeConvertBuilder.NewWithAllProps(input).ConvertTime());
        }

        [Theory]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("07:05:45PM", "19:05:45")]
        public void ConvertTimeLibSucess(string input, string output)
        {
            Assert.Equal(output, TimeConvertBuilder.NewWithAllProps(input).ConvertTimeLib());
        }
    }
}

