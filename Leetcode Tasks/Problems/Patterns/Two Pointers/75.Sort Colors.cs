using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    /*
        Example 1:
        Input: nums = [2,0,2,1,1,0]
        Output: [0,0,1,1,2,2]
        Example 2:
        Input: nums = [2,0,1]
        Output: [0,1,2]
     */
    public void SortColors(int[] nums)
    {
        int p0 = 0;              // next position for 0
        int p2 = nums.Length - 1; // next position for 2
        int i = 0;

        while (i <= p2)
        {
            if (nums[i] == 0)
            {
                (nums[i], nums[p0]) = (nums[p0], nums[i]);
                p0++;
                i++;
            }
            else if (nums[i] == 2)
            {
                (nums[i], nums[p2]) = (nums[p2], nums[i]);
                p2--;
            }
            else
            {
                i++;
            }
        }
    }
}