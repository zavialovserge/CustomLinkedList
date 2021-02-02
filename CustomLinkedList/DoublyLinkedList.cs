using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class DoublyLinkedList : AbstatractLinkedList<TwoWayNode>
    {
        public override void Append(string value)
        {
            TwoWayNode new_node = new TwoWayNode(value);

            if (Head == null)
            {
                Head = new_node;
            }
            else
            {
                Tail.Next = new_node;
                new_node.Previous = Tail;
            }

            Tail = new_node;
            Count++;
        }

        public override bool DeleteNode(string value)
        {
            TwoWayNode previous = null;
            TwoWayNode current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;

                        }
                        Count--;

                    }
                    else
                    {
                        if (Count == 1)
                        {
                            Head = null;
                            Tail = null;
                        }
                        else
                        {
                            Head = current.Next;
                            Head.Previous = null;                            
                        }
                        Count--;
                        return true;
                    }
                }


                previous = current;
                current = current.Next;

            }
            return false;
        }
    }
}
