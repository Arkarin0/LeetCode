using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnersGuide
{

    // https://leetcode.com/problems/middle-of-the-linked-list/
    public class P876_MiddleOfLinkedList
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MiddleNode(ListNode head)
        {
            int count = 1;
            ListNode node = head;
            Dictionary<int, ListNode> dic= new Dictionary<int, ListNode>()
            {
                { 1, node },
            };
            
            while (node.next != null)
            {
                node = node.next;
                count++;

                dic.Add(count, node );
            }

            if (count == 1) { return head; }
            else if( count %2 != 0 ) { count--; }

            var id = (count / 2) + 1;

            return dic[id];            
        }

        public ListNode MiddleNodeSuperFast(ListNode head)
        {
            ListNode oneStepPointer = head;
            ListNode twoStepPointer = head;

            while (twoStepPointer.next != null)
            {
                oneStepPointer = oneStepPointer.next;
                twoStepPointer = twoStepPointer.next.next;

                if (twoStepPointer == null)
                    break;
            }

            return oneStepPointer;
        }

    }
}
