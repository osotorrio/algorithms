using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Queues.StackByQueues
{
    public class StackByQueuesTests
    {
        [Fact]
        public void StatckByTwoQueuesTest()
        {
            var stack = new StatckByTwoQueues<string>();

            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            var popped = stack.Pop();
            popped.ShouldBe("three");

            popped = stack.Pop();
            popped.ShouldBe("two");

            popped = stack.Pop();
            popped.ShouldBe("one");
        }

        [Fact]
        public void QueueReversionByRecursion()
        {
            var queue = new Queue<string>();

            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");

            queue = queue.ReverseByRecursion();

            var frontItem = queue.Dequeue();
            frontItem.ShouldBe("three");

            frontItem = queue.Dequeue();
            frontItem.ShouldBe("two");

            frontItem = queue.Dequeue();
            frontItem.ShouldBe("one");
        }
    }
}
