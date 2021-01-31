using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class CustomLinkedList : AbstatractLinkedList<Node>
    {
        /// <summary>
        /// Adding to the end of the linked list
        /// </summary>
        /// <param name="value">value</param>
        public override void Append(string value)
        {
            Node new_node = new Node(value);

            if (Head == null)
            {
                Head = new_node;
            }
            else
            {
                Tail.Next = new_node;
            }
            Tail = new_node;
            Count++;
        }

        /// <summary>
        /// Delete node from linked List
        /// </summary>
        /// <param name="node">Node</param>
        /// <returns></returns>
        public override bool DeleteNode(string value)
        {
            Node previous = null;
            Node current = Head;
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
                                               
                    }
                    else
                    {
                        Head = Head.Next;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }
                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;

            }
            return false;
        }


    }
}
