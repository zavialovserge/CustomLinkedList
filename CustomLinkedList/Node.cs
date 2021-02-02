namespace CustomLinkedList
{
    /// <summary>
    ///  Represents a node in a AbstractNode.
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
