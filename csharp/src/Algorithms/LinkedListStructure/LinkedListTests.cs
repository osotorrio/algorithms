using Shouldly;
using Xbehave;

namespace Algorithms.LinkedListStructure
{
    public class LinkedListTests
    {
        [Scenario]
        public void AddBeforeFirstEmptyListTest(LinkedList<int> list)
        {
            "Given an empty list".x(() => 
            {
                list = new LinkedList<int>();
            });

            "When adding a node before the head".x(() =>
            {
                list.AddBeforeFirst(3);
            });

            "Then head should be the added node".x(() =>
            {
                list.Head.Value.ShouldBe(3);
                list.Head.Next.ShouldBeNull();
            });

            "And tail should be the added node".x(() =>
            {
                list.Tail.Value.ShouldBe(3);
                list.Tail.Next.ShouldBeNull();

            });

            "And the list should have 1 item".x(() =>
            {
                list.Count.ShouldBe(1);
            });
        }

        [Scenario]
        public void AddBeforeFirstNoneEmptyListTest(LinkedList<int> list)
        {
            "Given a list with 1 item".x(() =>
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(5);
            });

            "When adding a node before the head".x(() =>
            {
                list.AddBeforeFirst(3);
            });

            "Then head should be the added node".x(() =>
            {
                list.Head.Value.ShouldBe(3);
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

        [Scenario]
        public void AddAfterLastEmptyListTest(LinkedList<int> list)
        {
            "Given an empty list".x(() =>
            {
                list = new LinkedList<int>();
            });

            "When adding a node after the tail".x(() =>
            {
                list.AddAfterLast(3);
            });

            "Then head should be the added node".x(() =>
            {
                list.Head.Value.ShouldBe(3);
                list.Head.Next.ShouldBeNull();
            });

            "And tail should be the added node".x(() =>
            {
                list.Tail.Value.ShouldBe(3);
                list.Tail.Next.ShouldBeNull();

            });

            "And the list should have 1 item".x(() =>
            {
                list.Count.ShouldBe(1);
            });
        }

        [Scenario]
        public void AddAfterLastNoneEmptyListTest(LinkedList<int> list)
        {
            "Given an empty list".x(() =>
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
            });

            "When adding a node after the tail".x(() =>
            {
                list.AddAfterLast(5);
            });

            "Then head should remain the same pointing to the new node".x(() =>
            {
                list.Head.Value.ShouldBe(3);
                list.Head.Next.Value.ShouldBe(5);
            });

            "And tail should be the new node".x(() =>
            {
                list.Tail.Value.ShouldBe(5);
                list.Tail.Next.ShouldBeNull();
            });

            "And the list should have 2 items".x(() =>
            {
                list.Count.ShouldBe(2);
            });
        }

        [Scenario]
        public void RemoveFirstListOneItemTest(LinkedList<int> list)
        {
            "Given a list with 1 item".x(() => 
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
            });

            "When removing the first item".x(() =>
            {
                list.RemoveFirst();
            });

            "Then the list is empty".x(() =>
            {
                list.Head.ShouldBeNull();
                list.Tail.ShouldBeNull();
                list.Count.ShouldBe(0);
            });
        }

        [Scenario]
        public void RemoveFirstListMultiItemsTest(LinkedList<int> list)
        {
            "Given a list with 2 items".x(() => 
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
                list.AddAfterLast(5);
            });

            "When removing the first item".x(() =>
            {
                list.RemoveFirst();
            });

            "Then head points to null".x(() =>
            {
                list.Head.Value.ShouldBe(5);
                list.Head.Next.ShouldBeNull();
            });

            "And tail should be equal to head".x(() =>
            {
                list.Tail.Value.ShouldBe(5);
                list.Tail.Next.ShouldBeNull();
            });

            "And the list should have 1 iteam".x(() =>
            {
                list.Count.ShouldBe(1);
            });
        }
    }
}
