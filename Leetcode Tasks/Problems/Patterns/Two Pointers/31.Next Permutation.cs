using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    /*
     Example 1:

        Input: nums = [1,2,3]
        Output: [1,3,2]
        Example 2:
        
        Input: nums = [3,2,1]
        Output: [1,2,3]
        Example 3:
        
        Input: nums = [1,1,5]
        Output: [1,5,1]
     */
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int i = n - 2;

        // Step 1: Find the first decreasing element from the right
        while (i >= 0 && nums[i] >= nums[i + 1])
            i--;

        if (i >= 0)
        {
            // Step 2: Find element just larger than nums[i]
            int j = n - 1;
            while (nums[j] <= nums[i])
                j--;

            // Step 3: Swap
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        // Step 4: Reverse suffix
        Array.Reverse(nums, i + 1, n - (i + 1));
    }
}