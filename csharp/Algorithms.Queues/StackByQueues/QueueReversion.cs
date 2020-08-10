using System.Collections.Generic;

namespace Algorithms.Queues.StackByQueues
{
    public static class QueueReversion
    {
        public static Queue<string> ReverseByRecursion(this Queue<string> queue)
        {
            Reverse();

            void Reverse()
            {
                if (queue.Count == 0) return;

                var frontItem = queue.Dequeue();
                    
                Reverse();

                queue.Enqueue(frontItem);
            }

            return queue;
        }
    }
}
