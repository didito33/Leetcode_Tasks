using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        var result = -1;
        int hLength = haystack.Length;
        int nLength = needle.Length;
        if(hLength == nLength && haystack == needle)
            return 0;
        for (int i = 0; i < hLength; i++)
        {
            if (i + nLength <= hLength && haystack.Substring(i, nLength) == needle)
            {
                result = i;
                break;
            }
        }
        return result;
    }
}