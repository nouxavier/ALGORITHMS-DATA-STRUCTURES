using System;
using Algorithms.Exceptions;

namespace Algorithms.Sum
{
    public class SimpleSum
    {
        public int[] Input { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public SimpleSum(int[] input)
        {
            if (input == null || input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
        }

        public int ResultSum()
        {
            int result = 0;
            for (int i = 0; i <= Input.Length - 1; i++)
            {
                result += Input[i];
            }

            return result;
        }

        public int ResultSumList(List<int> input)
        {
            int result = 0;
            for (int i = 0; i <= input.Count - 1; i++)
            {
                result += input.ElementAt(i);
            }

            return result;
        }
    }
}

