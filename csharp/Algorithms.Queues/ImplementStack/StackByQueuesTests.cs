using Shouldly;
using Xunit;

namespace Algorithms.Queues.ImplementStack
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
    }
}
