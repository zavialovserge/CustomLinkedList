using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    /// <summary>
    ///  Represents a node in a AbstractNode. This class cannot
    //     be inherited.
    /// </summary>
    public class Node : AbstractNode<Node>
    {
        /// <summary>
        ///  Initializes a new instance of the CustomLinkedList
        //     class, containing the specified value.
        /// </summary>
        /// <param name="value"></param>
        public Node(string value) : base(value)
        {
        }
    }
}
