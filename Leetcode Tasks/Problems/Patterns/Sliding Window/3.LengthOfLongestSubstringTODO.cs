using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int LengthOfLongestSubstring(string s)//TODO
    {
        HashSet<char> set = new HashSet<char>();
        int maxLength = 0;
        var left = 0;
        for (int i = 0; i < s.Length; i++)
        {
            while(set.Contains(s[i]))
            {
                set.Remove(s[left]);
                left++;//start from next char
            }
            set.Add(s[i]);
            maxLength = Math.Max(maxLength, i - left + 1);
        }
        return maxLength;
    }
}