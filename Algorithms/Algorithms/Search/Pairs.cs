using System;
namespace Algorithms.Search
{
    public class Pairs
    {
        public Pairs()
        {
        }

        //o n^2
        public static int CountPairs(int k, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j< arr.Length; j++)
                {
                    var result = arr[i] - arr[j];
                    if (result == k)
                        count++;
                }
            }

            return count;

        }
        public static int CountGood(int k, int[] arr)
        {
            int count = 0;
            int left = 0;
            int right = 1;
            Array.Sort(arr);
            while (right < arr.Length)
            {
                var val = arr[right] - arr[left];
                if (val == k)
                {
                    right++;
                    left++;
                    count++;
                }
                if (val < k)
                {
                    right++;
                }

            }



            return count;

        }
        public static int CountListGood(int k, List<int> arr)
        {
            int count = 0;
            int left = 0;
            int right = 1;
            arr.Sort();
            while(right < arr.Count)
            {
                var val = arr[right] - arr[left];
                if(val == k)
                {
                    right++;
                    left++;
                    count++;
                }
                else if(val < k)
                {
                    right++;
                }
                else
                {
                    left++;
                    if (left == right)
                        right += 1;
                }
              
            }

             

            return count;
                                                                                                             
        }
    }
}

