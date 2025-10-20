using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public string LongestCommonPrefix(string[] strs) //["flower","flow","flight"]
    {
        var strResult = string.Empty;
        if (strs == null || strs.Length == 0)
            return strResult;
        var minLength = strs.Select(s => s.Length).Min();
        for (int i = 0; i < minLength;)//characters of each string
        {
            for (int j = 0; j < strs.Length; j++)//strings
            {
                var prefix = strs[j].Substring(i, 1);
                if (strs.All(s => s.Substring(i, 1) == prefix))
                {
                    strResult += prefix;
                    if(i == minLength - 1)
                        return strResult;
                    i++;
                    continue;
                }
                return strResult;
            }
        }
        return strResult;//"fl"
    }
}