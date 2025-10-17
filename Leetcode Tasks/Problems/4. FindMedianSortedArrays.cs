using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 1 && nums2.Length == 1)
            return (nums1[0] + nums2[0]) / 2.0;
         var merged = new int[nums1.Length + nums2.Length];
        merged = nums1.Concat(nums2).ToArray();
        Array.Sort(merged);
        if(merged.Count() % 2 == 0)
        {
            int midIndex1 = merged.Count() / 2;
            int midIndex2 = midIndex1 - 1;
            return (merged[midIndex1] + merged[midIndex2]) / 2.0;
        }
        else
        {
            int midIndex = merged.Count() / 2;
            return merged[midIndex];
        }
    }
}