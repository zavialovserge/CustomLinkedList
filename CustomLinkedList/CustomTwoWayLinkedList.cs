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

            if (_head == null)
            {
                _head = new_node;
            }
            else
            {
                _tail.Next = new_node;
                new_node.Previous = _tail;
            }

            _tail = new_node;
            Count++;
        }

        protected override bool DeleteNode(string value)
        {
            throw new NotImplementedException();
        }
    }
}
