using System;

namespace Algorithms.LinkedLists.SinglyLinkedList
{
    public sealed class SinglyLinkedNode<T>
    {
        public T Value { get; set; }

        public SinglyLinkedNode<T> Next { get; set; }
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

            var node = First;

            while(node.Next != null)
            {
                node = node.Next;
            }

            Last = new SinglyLinkedNode<T> { Value = value };
            node.Next = Last;
            return Last;
        }

        public SinglyLinkedNode<T> AddAfter(SinglyLinkedNode<T> target, T value)
        {
            var current = First;

            while(current != null)
            {
                if (Object.ReferenceEquals(current, target))
                {
                    var node = new SinglyLinkedNode<T> { Value = value };

                    if (Object.ReferenceEquals(Last, target))
                    {
                        Last = node;
                    }

                    node.Next = current.Next;
                    current.Next = node;
                    return node;
                }

                current = current.Next;
            }

            throw new InvalidOperationException("The target node does not belong to the list");
        }

        public SinglyLinkedNode<T> AddBefore(SinglyLinkedNode<T> target, T value)
        {
            if (Count != 0)
            {
                SinglyLinkedNode<T> previous = null;
                var node = new SinglyLinkedNode<T> { Value = value };

                if (Object.ReferenceEquals(First, target))
                {
                    previous = First;
                    First = node;
                    First.Next = previous;
                    return node;
                }
                else
                {
                    var current = First;

                    while (current != null)
                    {
                        if (Object.ReferenceEquals(current, target))
                        {
                            First = previous;
                            node.Next = current;
                            First.Next = node;
                            return node;
                        }

                        previous = current;
                        current = current.Next;
                    }
                }
            }

            throw new InvalidOperationException("The target node does not belong to the list");
        }

        public SinglyLinkedNode<T> Find(T value)
        {
            SinglyLinkedNode<T> node = null;

            var current = First;

            while(current != null)
            {
                if (current.Value.Equals(value))
                {
                    node = current;
                    break;
                }

                current = current.Next;
            }

            return node;
        }
    }
}