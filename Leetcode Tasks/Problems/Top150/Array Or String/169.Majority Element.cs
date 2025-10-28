using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
                dict[num] = 1;
            else
                dict[num]++;
        }
        return dict.FirstOrDefault(x => x.Value > nums.Length / 2).Key;
    }
}