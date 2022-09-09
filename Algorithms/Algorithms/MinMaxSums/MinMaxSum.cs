using System;
using Algorithms.Exceptions;

namespace Algorithms.MinMaxSums
{
    public class MinMaxSum
    {
        public int[] Input { get; private set; }
        public List<int> InputList { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public MinMaxSum(int[] input)
        {
            if(input == null || input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
            InputList = input.ToList();
        }

        public void PrintSum()
        {
            Array.Sort(Input);
            long min = 0;
            long max = 0;
            int size = Input.Length - 1;
            for (int i = 0; i <= size; i++)
            {
                if (i != size)
                    min = min + Input[i];

                if (i != 0)
                    max = max + Input[i];
            }

            Console.Write("{0} {1}", min, max);
        }

        public void PrintLisSum()
        {
            InputList.Sort();
            long min = 0;
            long max = 0;
            int size = InputList.Count - 1;
            for (int i = 0; i <= size; i++)
            {
                if (i != size)
                    min = min + InputList[i];

                if (i != 0)
                    max = max + InputList[i];
            }

            Console.Write("{0} {1}", min, max);
        }
        public void PrintLisWithoutSortSum()
        {
            int min = InputList[0];
            int max = InputList[0];
            long sum = 0;
            for (int i = 0; i <= InputList.Count - 1; i++)
            {

                if (min > InputList[i])
                    min = InputList[i];

                if (max < InputList[i])
                    max = InputList[i];

                sum += InputList[i];
            }

            Console.Write("{0} {1}", (sum - max), (sum - min));

        }

        public void PrintArrayWithoutSortSum()
        {
            int min = Input[0];
            int max = Input[0];
            long sum = 0;
            for (int i = 0; i <= Input.Length - 1; i++)
            {

                if (min > Input[i])
                    min = Input[i];

                if (max < Input[i])
                    max = Input[i];

                sum += Input[i];
            }

            Console.Write("{0} {1}", (sum - max), (sum - min));
        }

    }
}

