using System;

namespace Algorithms.LinkedLists.SinglyLinkedList
{
    public sealed class SinglyLinkedNode<T>
    {
        public T Value { get; set; }

        public SinglyLinkedNode<T> Next { get; }
    }

    public class SinglyLinkedList<T>
    {
        public SinglyLinkedNode<T> First { get; private set; }

        public SinglyLinkedNode<T> Last { get; private set; }

        public int Count 
        { 
            get 
            {
                var counter = 0;
                var node = First;

                while (node != null)
                {
                    counter++;
                    node = node.Next;
                }

                return counter;
            }
        }

        public SinglyLinkedNode<T> AddFirst(T value)
        {
            First = new SinglyLinkedNode<T> { Value = value };
            Last = First;
            return First;
        }

        public SinglyLinkedNode<T> AddLast(T value)
        {
            if (Count == 0)
            {
                return AddFirst(value);
            }

            return null;
        }
    }
}