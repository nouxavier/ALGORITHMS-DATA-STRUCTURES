using System;
using Algorithms.Time;

namespace Algorithms.Test.Time
{
    public class TimeConvertBuilder
    {
        public static TimeConvert NewWithAllProps(string input)
        {
            return new TimeConvert(input);
        }
    }
}

