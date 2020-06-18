using System.Runtime.ConstrainedExecution;

namespace Algorithms.LinkedListStructure
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(Node<T> node)
        {
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                var current = Head;
                Head = node;
                Head.Next = current;
            }

            Count++;
        }
    }
}