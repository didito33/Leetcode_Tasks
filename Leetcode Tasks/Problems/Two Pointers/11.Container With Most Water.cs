using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxWater = 0;

        while( left <= right)
        {
            int currentMinHeight = Math.Min(height[left], height[right]);
            int currentWidth = right - left;
            int currentWater = currentMinHeight * currentWidth;

            maxWater = Math.Max(maxWater, currentWater);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        return maxWater;
    }
}