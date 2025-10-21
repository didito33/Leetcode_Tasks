using Leetcode_Tasks.Models;
using System;
using System.Text;

namespace Leetcode_Tasks.Problems;
public partial class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return new List<string>();

        var phoneMap = new Dictionary<char, string>
        {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" },
            { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" },
            { '8', "tuv" }, { '9', "wxyz" }
        };

        var result = new List<string>();
        var current = new StringBuilder();

        void Backtrack(int index)
        {
            // Base case: if we've built a combination of full length
            if (index == digits.Length)
            {
                result.Add(current.ToString());
                return;
            }

            string letters = phoneMap[digits[index]];

            foreach (char letter in letters)
            {
                current.Append(letter);
                Backtrack(index + 1);     
                current.Length--;         
            }
        }

        Backtrack(0);
        return result;
    }
}