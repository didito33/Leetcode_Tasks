using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
            return k;
    }
}