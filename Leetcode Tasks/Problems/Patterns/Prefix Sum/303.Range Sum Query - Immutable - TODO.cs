using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public class NumArray
    {
        private int[] prefixSums;
        public NumArray(int[] nums)
        {

        }

        public int SumRange(int left, int right)
        {
            if( left == 0)
                return prefixSums[right];

            return prefixSums[right] - prefixSums[left - 1];
        }
    }

}