using System;
namespace Algorithms.SimpleArraySum
{
    public class Sum
    {
        public int[] Input { get; private set; }

        public Sum(int[] input)
        {
            if(input.Length <0)
                throw new ArgumentException("Input for sum must be greater than zero");

            Input = input;
        }

        public int ResultSum()
        {
            int result = 0;
            for (int i = 0; i <= Input.Length - 1; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
