using System;
namespace Algorithms.Sort
{
    /*
     Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

    We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

    You must solve this problem without using the library's sort function.

 

    Example 1:

    Input: nums = [2,0,2,1,1,0]
    Output: [0,0,1,1,2,2]
    Example 2:

    Input: nums = [2,0,1]
    Output: [0,1,2]
 

    Constraints:

    n == nums.length
    1 <= n <= 300
    nums[i] is either 0, 1, or 2.

     */
    public class ColorSort
    {
        public ColorSort()
        {

        }

        /*public static int[] Sorting(int[] nums, int begin, int end)
        {
            int l = nums.Length;
            if (l == 0)
                return Array.Empty<int>();

            int pivot = nums[l - 1];
            if(begin < end)
            {List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            var expect = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
            expect.Sort();
          //  var teste = QuickSort2.Sort(inputs, 0, inputs.Count - 1);

            }

        }

        private int[] Partional(int[] nums)
        {
            int l = nums.Length;
            int pivot = nums[l - 1];
            int j = 0;
            for(int i = j; i < l-1; i++)
            {
                if (nums[i] <= pivot)
                {
                    int aux = nums[i];
                    nums[i] = nums[j];
                    nums[j] = aux;
                    j++;
                }
            }
            //remove pivot



        }*/


    }
}

