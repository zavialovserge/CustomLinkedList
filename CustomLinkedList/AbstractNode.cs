using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{

    /// <summary>
    /// Represent Abstraction Node
    /// </summary>
    /// <typeparam name="T">AbstractNode</typeparam>
    public abstract class AbstractNode<T>
    {
        public string Value { get; set; }
        public T Next { get; set; }
        public AbstractNode(string value)
        {
            this.Value = value;
            Next = default(T);
        }
    }
}
