using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Algorithms.LinkedListStructure
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddBeforeFirst(T value)
        {
            AddBeforeFirst(new Node<T>(value));
        }

        private void AddBeforeFirst(Node<T> node)
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

        public void AddAfterLast(T value)
        {
            AddAfterLast(new Node<T>(value));
        }

        private void AddAfterLast(Node<T> node)
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

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    var current = Head;

                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }

        public IEnumerable<T> GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}