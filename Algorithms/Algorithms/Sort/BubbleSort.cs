using System;
namespace Algorithms.Sort
{
    public class BubbleSort
    {
        public BubbleSort()
        {
        }

        public static List<int> SortCrescent(List<int> ints)
        {
            int n = ints.Count;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (ints[i] > ints[i + 1])
                    {
                        var aux = ints[i + 1];
                        ints[i + 1] = ints[i];
                        ints[i] = aux;

                    }
                }
            }

            return ints;
        }
        public static List<int> SortDescending(List<int> ints)
        {
            int n = ints.Count;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (ints[i] < ints[i + 1])
                    {
                        var aux = ints[i + 1];
                        ints[i + 1] = ints[i];
                        ints[i] = aux;

                    }
                }
            }

            return ints;
        }
    }
}

