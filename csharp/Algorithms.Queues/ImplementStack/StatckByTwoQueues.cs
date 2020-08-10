using System.Collections.Generic;

namespace Algorithms.Queues.ImplementStack
{
    public class StatckByTwoQueues<T>
    {
        private Queue<T> _mainQueue = new Queue<T>();

        private Queue<T> _helperQueue = new Queue<T>();

        public void Push(T newItem)
        {
            while (_mainQueue.Count != 0)
            {
                _helperQueue.Enqueue(_mainQueue.Dequeue());
            }

            _mainQueue.Enqueue(newItem);

            while(_helperQueue.Count != 0)
            {
                _mainQueue.Enqueue(_helperQueue.Dequeue());
            }
        }

        public T Pop()
        {
            return _mainQueue.Dequeue();
        }
    }
}
