using System;
using Algorithms.Exceptions;

namespace Algorithms.Sort
{
    public class InsertSort
    {
        public int[] Input { get; private set; }
        public List<int> LInput { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public InsertSort(int[] input)
        {
            if (input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
            LInput = input.ToList();
        }

        public int[] InsertSorting()
        {
            for (int i = Input.Length - 1; i > 0; i--)
            {
                var aux = Input[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    var v2 = Input[j];
                    if (v2 > aux)
                    {
                        Input[j + 1] = Input[j];
                        Console.WriteLine("[{0}]", string.Join(" ", Input));
                        Input[j] = aux;
                    }

                }

            }
            Console.WriteLine("[{0}]", string.Join(" ", Input));
            return Input;
        }
        public int[] InsertSortingWhile()
        {
            var j = 0;
            for (var i = 1; i < Input.Length; i++)
            {
                var value = Input[i];
                j = i - 1;
                while (j >= 0 && value < Input[j])
                {
                    Input[j + 1] = Input[j];
                    j = j - 1;
                }
                Input[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", Input));
            return Input;
        }

        public int InsertSortingShift()
        {
            var j = 0;
            var shift = 0;
            for (var i = 1; i < LInput.Count; i++)
            {
                var value = LInput[i];
                j = i - 1;
                while (j >= 0 && value < LInput[j])
                {
                    LInput[j + 1] = LInput[j];
                    j = j - 1;
                    shift = shift + 1;
                }
                LInput[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", LInput));
            return shift;
        }
    }

}

