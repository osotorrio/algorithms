using System.Collections.Generic;

namespace Algorithms.Queues.StackByQueues
{
    public class StackByOneQueue<T>
    {
        private Queue<T> _queue = new Queue<T>();

        public void Push(T item)
        {
            _queue.Enqueue(item);
        }

        public T Pop()
        {
            Reverse();

            var item = _queue.Dequeue();

            Reverse();

            return item;
        }

        private void Reverse()
        {
            if (_queue.Count == 0) return;

            var item = _queue.Dequeue();

            Reverse();

            _queue.Enqueue(item);
        }
    }
}
