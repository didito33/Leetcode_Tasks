using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Top150;
public partial class Solution
{
    public int RemoveDuplicates01(int[] nums)
    {
        int k = 1;
        var dict = new Dictionary<int, int>();
        dict[nums[0]] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = 1;
                nums[k] = nums[i];
                k++;
            }
            else if(dict[nums[i]] == 1)
            {
                dict[nums[i]]++;
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}