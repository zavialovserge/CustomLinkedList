using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    class Node : AbstractNode<Node>
    {
        public Node(string value) : base(value)
        {
        }
    }
}
