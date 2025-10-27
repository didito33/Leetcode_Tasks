using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            if (nums[left] != 0)
            {
                left++;
            }
            else
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                right--;
            }
        }
    }
}