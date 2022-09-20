using System;
using Algorithms.Exceptions;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Algorithms.Sort
{
    public class QuickSort
    {
        public int[] Input { get; private set; }
        public List<int> LInput { get; private set; }
        const string MSG = "Input for sum must be greater than zero";

        public QuickSort(int[] input)
        {
            if (input.Length <= 0)
                throw new DomainException(MSG);

            Input = input;
            LInput = input.ToList();
        }

        public List<int> SortingList(int p)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> equal = new List<int>();
            for(int i = 0; i <= LInput.Count - 1;i++)
            {
                if (p > LInput[i])
                    left.Add(LInput[i]);
                else if(p < LInput[i])
                    right.Add(LInput[i]);
                else
                    equal.Add(LInput[i]);
            }

            return left.Concat(equal).Concat(right).ToList();

        }
        public List<int> SortingAlternativeList()
        {
            
            List<int> aux = new List<int>(new int[LInput.Max()+1]);
            
            int index = 0;
            for (int i = 0; i <= LInput.Count - 1; i++)
            {
                index = LInput[i];
                aux[index] += 1;
            }
            return aux;

        }

        public List<int> ConvertListIndex(List<int> lIndex)
        {
            List<int> aux2 = new List<int>();
            for (int i = 0; i <= lIndex.Count - 1; i++)
            {
                if (lIndex[i] != 0)
                {
                    for (int j = 0; j < lIndex[i]; j++)
                    {
                        aux2.Add(i);
                    }
                }

            }
            return aux2;
        }

        public static void CountSort(int[]arr )
        {
            int max = arr.Max();
            int min = arr.Min();
            int range = max - min + 1;
            int[] count = new int[range];
            int[] output = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }
        public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}

