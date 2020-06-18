using System;
using System.Runtime.ConstrainedExecution;

namespace Algorithms.LinkedListStructure
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddBeforeFirst(Node<T> node)
        {
            var current = Head;
            Head = node;
            Head.Next = current;
            Count++;

            if (Count == 1)
            {
                Tail = node;
            }
        }

        public void AddAfterLast(Node<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }
    }
}