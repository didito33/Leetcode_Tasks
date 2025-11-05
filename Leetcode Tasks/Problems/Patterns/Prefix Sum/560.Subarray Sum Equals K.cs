using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{                       //nums = [1,2,3], k = 3  
                        //output: 2
    public int SubarraySum(int[] nums, int k)
    {
        var prefixSum = 0;
        int count = 0;
        Dictionary<int, int> prefixSumCounts = new Dictionary<int, int>();
        prefixSumCounts[0] = 1; // To handle the case when prefixSum itself equals k
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            
            if(prefixSumCounts.ContainsKey(prefixSum - k))
            {
                count += prefixSumCounts[prefixSum - k];// Found a subarray ending at index i with sum k
            } 
            if (prefixSumCounts.ContainsKey(prefixSum))
            {
                prefixSumCounts[prefixSum]++;// Increment the count of this prefix sum
            }
            else
            {
                prefixSumCounts[prefixSum] = 1;// Initialize the count of this prefix sum
            }
        }
        return count;
    }
}