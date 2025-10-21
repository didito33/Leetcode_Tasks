using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        Dictionary<int[], int> closest = new Dictionary<int[], int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                closest[[nums[i], nums[left], nums[right]]] = sum;
                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
                closest[[nums[i], nums[left], nums[right]]] = sum;
            }
        }
        return closest.Values.OrderBy(s => Math.Abs(s - target)).First();
    }
}