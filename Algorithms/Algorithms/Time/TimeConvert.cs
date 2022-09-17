using System;
using Algorithms.Exceptions;

namespace Algorithms.Time
{
    public class TimeConvert
    {
        public string TimeInput { get; private set; }
        const string MSG_SIZE = "Time must be format HH:MM:SSAM or HH:MM:SSPM";


        public TimeConvert(string time)
        {
            TimeInput = time;
            if (time.Length != 10)
                throw new DomainException(MSG_SIZE);

            TimeInput = time;
        }

        public string ConvertTime()
        {
            var letter = TimeInput.Substring(TimeInput.Length - 2, 2);
            var time = TimeInput.Substring(0, TimeInput.Length - 2).Split(':');

            if (time.Length != 3)
                throw new DomainException(MSG_SIZE);

            if (letter == "AM")
            {
                if (int.Parse(time[0]) >= 12)
                {
                    time[0] = (int.Parse(time[0]) - 12).ToString();
                    return FormatTime(time);
                }
                return FormatTime(time);
            }
            else if(letter == "PM" && time.Length == 3)
            {
                if (int.Parse(time[0]) < 12)
                {
                    time[0] = (int.Parse(time[0]) + 12).ToString();
                    return FormatTime(time);
                }
                return FormatTime(time);

            }
            throw new DomainException(MSG_SIZE);

        }

        private static string FormatTime(string[] time)
        {
            return String.Format("{0}:{1}:{2}", time[0].ToString().PadLeft(2, '0'), time[1].ToString().PadLeft(2, '0'), time[2].ToString().PadLeft(2, '0'));
        }

        public string ConvertTimeLib()
        {
            bool convertion = DateTime.TryParse(TimeInput, out DateTime time);

            if(!convertion)
                throw new DomainException(MSG_SIZE);

            return time.ToString("HH:mm:ss");
        }

    }
}

