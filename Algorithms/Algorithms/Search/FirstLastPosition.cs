using System;
namespace Algorithms.Search
{
    public class FirstLastPosition
    {
        public FirstLastPosition()
        {
        }
        public  int[] SearchRange(int[] nums, int target)
        {
            int lastIndex = nums.Length - 1;
            return SearchIndex(nums, target, 0, lastIndex);
          

        }

        private int[] SearchIndex(int[]nums, int target, int begin, int end)
        {
            int midle = ((begin + end) / 2);

            if (nums[midle] == target)
            {
                //search first position
                
                if(midle < nums.Length && nums[midle + 1] > target)
                {
                    int indexFirt = -1;
                    for (int i = midle - 1; i >=0; i--)
                    {
                        if (nums[i]!= target)
                        {
                            return new int[] { indexFirt, midle };
                        }
                        indexFirt = i;
                    }
                    return new int[] { indexFirt, midle };
                }
                else
                {
                    int indexLast = -1;
                    for (int i = midle +1; i < nums.Length ; i++)
                    {
                        if (nums[i] != target)
                        {
                            return new int[] { midle, indexLast};
                        }
                        indexLast = i;
                    }
                    return new int[] { midle, indexLast };
                }
            }
                
            else if (target < nums[midle])
                SearchIndex(nums, target, begin, midle - 1);
            else
                return SearchIndex(nums, target, midle + 1, end);

            return new int[] {-1,-1};
        }

    }
}

