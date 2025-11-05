using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public bool CanJump(int[] nums)
    {
        int maxReachIdx = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            // If we’re stuck before reaching this index
            if (i > maxReachIdx)
                return false;

            // Extend our maximum reachable range
            maxReachIdx = Math.Max(maxReachIdx, i + nums[i]);

            // Optimization: if we can already reach or go beyond the last index
            if (maxReachIdx >= nums.Length - 1)
                return true;
        }

        return true;
    }
}