using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    /// <summary>
    /// Represents a one way linked list
    /// </summary>
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
        ///  Removes the node at the end of the CustomLinkedList
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns> true if the element containing value is successfully removed; otherwise, false.
        //     This method also returns false if value was not found in the original
        /// </returns>
        public override bool Remove(string value)
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
