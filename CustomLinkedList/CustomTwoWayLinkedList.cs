using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    class CustomTwoWayLinkedList : AbstatractLinkedList<TwoWayNode>
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
            throw new NotImplementedException();
        }
    }
}
