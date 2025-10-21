using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
/*    public bool IsMatch(string s, string p)
    {
        char[] sArr = s.ToCharArray();
        char[] pArr = p.ToCharArray();
        int higherLen = Math.Max(sArr.Length, pArr.Length);
        bool sArrStarFlag = false;
        bool pArrStarFlag = false;
        bool isStar(char c) => c == '*';
        bool isDot(char c) => c == '.';
        for (int i = 0; i < higherLen; i++)
        {
            if (isStar(sArr[i])) sArrStarFlag = true;
            if (isStar(pArr[i])) pArrStarFlag = true;
            if (isDot(pArr[i])) pArr[i] = sArr[i];
            if (isDot(sArr[i])) pArr[i] = sArr[i];

        }
    }*/
}