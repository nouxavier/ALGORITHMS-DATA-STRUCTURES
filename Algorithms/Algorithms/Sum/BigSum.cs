using System;
using Algorithms.Exceptions;

namespace Algorithms.Sum
{
    public class BigSum
    {
        public long[] Input { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public BigSum(long[] input)
        {
            if (input == null || input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
        }

        public long ResultSum()
        {
            long result = 0;
            for (int i = 0; i <= Input.Length - 1; i++)
            {
                result += Input[i];
            }

            return result;
        }

        public long ResultSumList(List<long> ar)
        {
            long result = 0;
            for (int i = 0; i <= ar.Count - 1; i++)
            {
                result += ar.ElementAt(i);
            }

            return result;
        }
    }
}

