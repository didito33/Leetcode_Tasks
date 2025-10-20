using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums); // sorting makes it easy to avoid duplicates

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add([nums[i], nums[left], nums[right]]);

                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) left++;//avoid dupes
                    while (left < right && nums[right] == nums[right + 1]) right--;// -;-
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}