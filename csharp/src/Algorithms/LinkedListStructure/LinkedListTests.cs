using Shouldly;
using Xbehave;

namespace Algorithms.LinkedListStructure
{
    public class LinkedListTests
    {
        [Scenario]
        public void AddFirstEmptyListTest(LinkedList<int> list)
        {
            "Given an empty list".x(() => 
            {
                list = new LinkedList<int>();
            });

            "When adding a node from the head".x(() =>
            {
                list.AddFirst(new Node<int>(5));
            });

            "Then head should be the added node".x(() =>
            {
                list.Head.Value.ShouldBe(5);
                list.Head.Next.ShouldBeNull();
            });

            "And tail should be the added node".x(() =>
            {
                list.Tail.Value.ShouldBe(5);
                list.Tail.Next.ShouldBeNull();

            });

            "And the list should have 1 item".x(() =>
            {
                list.Count.ShouldBe(1);
            });
        }

        [Scenario]
        public void AddFirstNoneEmptyListTest(LinkedList<int> list)
        {
            "Given an empty list".x(() =>
            {
                list = new LinkedList<int>();
                list.AddFirst(new Node<int>(5));
            });

            "When adding a node from the head".x(() =>
            {
                list.AddFirst(new Node<int>(1));
            });

            "Then head should be the added node".x(() =>
            {
                list.Head.Value.ShouldBe(1);
                list.Head.Next.Value.ShouldBe(5);
            });

            "And tail should be the previous node".x(() =>
            {
                list.Tail.Value.ShouldBe(5);
                list.Tail.Next.ShouldBeNull();
            });

            "And the list should have 2 items".x(() =>
            {
                list.Count.ShouldBe(2);
            });
        }
    }
}
