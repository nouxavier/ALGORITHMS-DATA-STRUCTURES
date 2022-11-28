using System;
namespace Algorithms.Sort
{
    public class InsertSort2
    {
        public InsertSort2()
        {
        }

        public static List<int> SortCrescent(List<int> ints)
        {
            int n = ints.Count;
            for(int i = 1; i < n; i++)
            {
                int j = i-1;
                var key = ints[i];

                while (j >= 0 && ints[j] > key)
                {
                    ints[j + 1] = ints[j];
                    j = j - 1;
                }
                ints[j + 1] = key;
            }

            return ints;
        }

        public static int SortCrescentShift(List<int> arr)
        {
            int n = arr.Count;
            int shift = 0;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                var key = arr[i];

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    shift++;
                }
                arr[j + 1] = key;
            }

            return shift;
        }
    }
}

