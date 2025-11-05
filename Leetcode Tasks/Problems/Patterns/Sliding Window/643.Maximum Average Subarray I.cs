using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int n = nums.Length;
        int sum = 0;
        //Initial window sum
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }
        int maxSum = sum;

        //Sliding
        for (int i = k; i < n; i++)
        {
            sum -= nums[i]; // Remove the element going out of the window
            sum += nums[i - k];// Add the element coming into the window
            maxSum = Math.Max(maxSum, sum);
        }
        return maxSum / k;
    }
}