using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    /// <summary>
    ///  Represents a node in a AbstractNode. 
    /// </summary>
    public class TwoWayNode : AbstractNode<TwoWayNode>
    {
        /// <summary>
        /// Previous node
        /// </summary>
        public TwoWayNode Previous { get; set; }
         /// <summary>
        ///  Initializes a new instance of the DoublyLinkedList
        //     class, containing the specified value.
        /// </summary>
        /// <param name="value"></param>
        public TwoWayNode(string value) : base(value)
        {
            Previous = null;
        }

    }
}
