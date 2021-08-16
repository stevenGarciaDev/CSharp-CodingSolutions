using System;

/*
LinkedList head, int k -> void

	LinkedList nodeBehind = head
	LinkedList nodeAhead = head
	
	move nodeAhead up k times to next 
	
	if (nodeAhead.next == null)
	{
		nodeBehind.value = nodeBehind.next.value;
		nodeBehind.next = nodeBehind.next;
		return;
	}
	
	while loop until nodeAhead.next == null
		nodeBehind.next = nodeBehind.next;
		

*/
namespace coding_problems.RemoveKthNodeFromEnd
{
    public class RemoveKthNode
    {
        public static void RemoveKthNodeFromEnd(LinkedList head, int k)
        {
            LinkedList nodeBehind = head;
            LinkedList nodeAhead = head;

            for (int i = 0; i < k; i++)
                nodeAhead = nodeAhead.Next;

            if (nodeAhead == null)
            {
                nodeBehind.Value = nodeBehind.Next.Value;
                nodeBehind.Next = nodeBehind.Next.Next;
                return;
            }

            while (nodeAhead.Next != null)
            {
                nodeBehind = nodeBehind.Next;
                nodeAhead = nodeAhead.Next;
            }


            nodeBehind.Next = nodeBehind.Next.Next;
        }

        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }
    }
}