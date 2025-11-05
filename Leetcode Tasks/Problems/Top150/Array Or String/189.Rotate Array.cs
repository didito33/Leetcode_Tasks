using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n;
        int[] copy = new int[n];

        for (int i = 0; i < n; i++)
        {
            copy[(i + k) % n] = nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = copy[i];
        }
    }
}