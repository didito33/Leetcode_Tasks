using Leetcode_Tasks.Models;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int LengthOfLongestSubstring(string s)//TODO
    {
        List<char> nextCharList = [];
        string resultCharList = "'/'";
        foreach (char c in s)
        {
            if (!nextCharList.Contains(c))
            {
                nextCharList.Add(c);
                resultCharList += c;
            }
            else
            {
                resultCharList += "'/'";
                resultCharList += c;
            }
        }
        string[] resultArray = resultCharList.Split("'/'");
        int[] ints = new int[resultArray.Length];
        int idx = 0;
        foreach (string str in resultArray)
        {
            ints[idx] = str.Length;
            idx++;
        }
        return ints.Max();
    }
}