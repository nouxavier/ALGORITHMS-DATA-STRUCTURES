using System;
namespace Algorithms.Search
{
    public class FindDuplicateNumber
    {
        public FindDuplicateNumber()
        {
        }

        //O(Nˆ2)
        public static int[] ForceBrute(int[] arr1, int[] arr2)
        {
            var duplicate = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                var number = arr1[i];
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (number == arr2[j])
                    {
                        duplicate.Add(number);
                    }
                }
            }
            return duplicate.ToArray();
        }

        //O(log 2n )
        public static int[] BinarySearch(int[] arr1, int[] arr2)
        {
            var duplicate = new List<int>();
            for (int i = 0; i < arr2.Length; i++)
            {
                var value = Search(arr1, arr2[i]);
                if (value != null)
                {
                    duplicate.Add(arr2[i]);
                }
            }
            return duplicate.ToArray();
        }

        private static int? Search(int[] numbers, int key)
        {
            int midle;
            int min = 0;
            int max = numbers.Length - 1;

            do
            {
                midle = (min + max) / 2;

                if (numbers[midle] == key)
                    return midle;
                else if (key > numbers[midle])
                    min = midle + 1;
                else
                    max = midle - 1;

            }
            while (min <= max);

            return null;
               
        }

    }
}

