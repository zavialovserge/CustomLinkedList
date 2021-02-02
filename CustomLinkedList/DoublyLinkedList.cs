namespace CustomLinkedList
{
    /// <summary>
    /// Represents a Doubly linked list
    /// </summary>
    public class DoublyLinkedList : AbstatractLinkedList<TwoWayNode>
    {

        /// <summary>
        /// Adds value at the end of DoublyLinkedList
        /// </summary>
        /// <param name="value">Value</param>
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
        /// <summary>
        ///  Removes value at the end of the DoublyLinkedList
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns> true if the element containing value is successfully removed; otherwise, false.
        //     This method also returns false if value was not found in the original
        /// </returns>
        public override bool Remove(string value)
        {
            TwoWayNode previous = null;
            TwoWayNode current = Head;
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
                        else
                        {
                            current.Next.Previous = previous;

                        }
                        Count--;

                    }
                    else
                    {
                        if (Count == 1)
                        {
                            Head = null;
                            Tail = null;
                        }
                        else
                        {
                            Head = current.Next;
                            Head.Previous = null;                            
                        }
                        Count--;
                        return true;
                    }
                }


                previous = current;
                current = current.Next;

            }
            return false;
        }
    }
}
