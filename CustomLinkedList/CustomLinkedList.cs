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

            if (_head == null)
            {
                _head = new_node;
            }
            else
            {
                _tail.Next = new_node;
            }
            _tail = new_node;
            Count++;
        }

        /// <summary>
        /// Delete node from linked List
        /// </summary>
        /// <param name="node">Node</param>
        /// <returns></returns>
        protected override bool DeleteNode(string value)
        {
            Node previous = null;
            Node current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous == null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                        _head = _head.Next;

                        // Список теперь пустой?
                        if (_head == null)
                        {
                            _tail = null;
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
