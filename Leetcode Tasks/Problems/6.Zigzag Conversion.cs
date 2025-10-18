using Leetcode_Tasks.Models;
using System;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    /*
            |    /|    /|    /|
            |  /  |  /  |  /  |
            |/    |/    |/    |
    */
    public string Convert(string s, int numRows)
    {

        if (numRows == 1 || s.Length <= numRows)
            return s;
        List<string> rows = new List<string>();
        for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            rows.Add(string.Empty);
        int currentRow = 0;
        bool goingDown = false;
        foreach (char c in s)
        {
            rows[currentRow] += c;
            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;
            currentRow += goingDown ? 1 : -1;
        }
        string result = string.Empty;
        foreach (string row in rows)
            result += row;
        return result;
    }
}