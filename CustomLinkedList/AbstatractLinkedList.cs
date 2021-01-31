using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
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
        public abstract void Append(string value);
        public abstract bool DeleteNode(string value);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>Node</returns>
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

        public int Count { get; set; }
    }
}
