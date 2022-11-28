using System;
namespace Algorithms.Sort
{
    public class SelectionSort
    {
        public SelectionSort()
        {
        }
    

        private  static int SearchIndexMin(List<int> ints, int minIndex, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (ints[i] < ints[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private static List<int> ChangePosition(List<int> ints, int j, int minIndex)
        {
            if (ints[j] > ints[minIndex])
            {
                int aux = ints[j];
                ints[j] = ints[minIndex];
                ints[minIndex] = aux;
            }

            return ints;
        }

        // 1 + (n-1)*[]
        public static List<int> SelectionCrescent(List<int> ints)
        {
            int n = ints.Count;
            int minIndex = 0;
            for (int j = 0; j< n - 1; j++)
            {
                minIndex = j;
                // search the minimun value 
                for (int i = j; i < n; i++)
                {
                    if (ints[i] < ints[minIndex])
                    {
                        minIndex = i;
                    }
                }
                if (ints[j] > ints[minIndex])
                {
                    int aux = ints[j];
                    ints[j] = ints[minIndex];
                    ints[minIndex] = aux;
                }

            }

            return ints;
        }

        public static List<int> SelectionDescending(List<int> ints)
        {
            int n = ints.Count;
            int maxIndex = 0;
            for (int j = 0; j < n - 1; j++)
            {
                maxIndex = j;
                // search the maximum value 
                for (int i = j; i < n; i++)
                {
                    if (ints[i] > ints[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                if (ints[j] < ints[maxIndex])
                {
                    int aux = ints[j];
                    ints[j] = ints[maxIndex];
                    ints[maxIndex] = aux;
                }

            }

            return ints;
        }

    }

    


}

