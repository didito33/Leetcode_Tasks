using Leetcode_Tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Tasks.Problems.Patterns.Two_Pointers
{
    public partial class Solution
    {
        // input: head = [1,2,3,4,5]
        // output: [5,4,3,2,1]
        public ListNode ReverseLinkedList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode nextTemp = current.next; // Store next node
                current.next = prev;              // Reverse the link
                prev = current;                   // Move prev to current
                current = nextTemp;               // Move to next node
            }
            return prev; // New head of the reversed list
        }
    }
}
