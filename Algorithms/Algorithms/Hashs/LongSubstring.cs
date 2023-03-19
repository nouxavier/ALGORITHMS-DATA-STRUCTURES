using System;
using System.Linq;

namespace Algorithms.Hashs
{
    public class LongSubstring
    {
        public static int LengthOfLongSubstring(string input)
        {
            HashSet<char> h = new HashSet<char>();

            var inputArray = input.ToCharArray();

            foreach(var item in inputArray)
            {
                if (!h.Contains(item))
                {
                    h.Add(item);
                }
            }

            return h.Count;
            
        }
    }
}

