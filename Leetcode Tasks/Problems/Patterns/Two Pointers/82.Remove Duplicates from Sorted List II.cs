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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            // Count occurrences
            var counts = new Dictionary<int, int>();
            ListNode node = head;
            while (node != null)
            {
                if (counts.ContainsKey(node.val)) 
                    counts[node.val]++;
                else 
                    counts[node.val] = 1;

                node = node.next;
            }

            // Dummy to simplify removal (handles head removal)
            var dummy = new ListNode(0);
            dummy.next = head;
            var cur = dummy;

            // Remove nodes whose value occurs more than once
            while (cur.next != null)
            {
                if (counts[cur.next.val] > 1)
                {
                    // skip the duplicate node
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            //dummy guarantees a safe pointer BEFORE the real head
            return dummy.next;//points to the first node of the modified list
        }
    }
}
