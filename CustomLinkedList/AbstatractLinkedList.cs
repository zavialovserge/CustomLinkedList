using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    /// <summary>
    /// Represents an abstract  linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstatractLinkedList<T> where T : AbstractNode<T>
    {
        /// <summary>
        /// First element
        /// </summary>
        public T Head { get;set; }
        /// <summary>
        /// Last element
        /// </summary>
        public T Tail { get; set; }
        /// <summary>
        ///  Adds the specified value at the end of LinkedList
        /// </summary>
        /// <param name="value">Value</param>
        public abstract void Append(string value);
        public abstract bool DeleteNode(string value);
        /// <summary>
        /// Determines whether a value is in the LinkedList
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns> // Returns:
        //     existing AbstractNode if value is found in the LinkedList; otherwise,
        //     null.
        //</returns>
        public T ContainsValue(string value)
        {
            T current_node = Head;
            while (current_node != null)
            {
                if (current_node.Value.Equals(value))
                {
                    return current_node;
                }

                current_node = current_node.Next;
            }
            return null;

        }
        /// <summary>
        /// Getting all values to array
        /// </summary>
        /// <returns>Return Array of values</returns>
        public string[] GetAllValues()
        {
            string[] array = new string[Count];
            int counter = 0;
            T current_node = Head;
            while (current_node != null)
            {
                array[counter] = current_node.Value;
                current_node = current_node.Next;
                counter++;
            }
            return array;
        }
        /// <summary>
        /// Gets the number of nodes actually contained in Linked List
        /// </summary>
        public int Count { get;  }
    }
}
