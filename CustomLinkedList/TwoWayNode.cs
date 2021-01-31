using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class TwoWayNode : AbstractNode<TwoWayNode>
    {
        public TwoWayNode Previous { get; set; }
        public TwoWayNode(string value) : base(value)
        {
            Previous = null;
        }

    }
}
