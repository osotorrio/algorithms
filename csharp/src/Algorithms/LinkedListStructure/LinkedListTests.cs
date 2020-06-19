using Shouldly;
using System.Collections.Generic;
using System.Linq;
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

        [Scenario]
        public void RemoveLastListOneItemTest(LinkedList<int> list)
        {
            "Given a list with 1 item".x(() => 
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
            });

            "When removing the last iteam".x(() =>
            {
                list.RemoveLast();
            });

            "Then the list is empty".x(() =>
            {
                list.Head.ShouldBeNull();
                list.Tail.ShouldBeNull();
                list.Count.ShouldBe(0);
            });
        }

        [Scenario]
        public void RemoveLastListMultiItemsTest(LinkedList<int> list)
        {
            "Given a list with 3 items".x(() => 
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
                list.AddAfterLast(5);
                list.AddAfterLast(7);
            });

            "When removing the last item".x(() => 
            {
                list.RemoveLast();
            });

            "Then the last item is removed".x(() =>
            {
                list.Head.Value.ShouldBe(3);
                list.Head.Next.Value.ShouldBe(5);
                list.Head.Next.Next.ShouldBeNull();
            });

            "And tail points to the new last item".x(() =>
            {
                list.Tail.Value.ShouldBe(5);
                list.Tail.Next.ShouldBeNull();
            });

            "And the list contains 2 items".x(() =>
            {
                list.Count.ShouldBe(2);
            });
        }

        [Scenario]
        // https://dzone.com/articles/ienumerable-vs-ienumerator
        public void GetEnumeratorTest(LinkedList<int> list, List<int> values)
        {
            "Given a list with 2 items".x(() => 
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
                list.AddAfterLast(5);
            });

            "When getting the enumerabled list".x(() =>
            {
                var enumerator = list.GetEnumerator();

                values = new List<int>();

                while (enumerator.MoveNext())
                {
                    values.Add(enumerator.Current);
                }
            });

            "Then the first node should be 3".x(() =>
            {
                values.First().ShouldBe(3);
            });

            "And the second node should be 5".x(() =>
            {
                values.Last().ShouldBe(5);
            });

            "And it should be equal nodes than items".x(() =>
            {
                values.Count().ShouldBe(list.Count);
            });
        }

        [Scenario]
        public void ClearTest(LinkedList<int> list)
        {
            "Given a list with multiple items".x(() => 
            {
                list = new LinkedList<int>();
                list.AddBeforeFirst(3);
                list.AddAfterLast(5);
                list.AddAfterLast(7);
            });

            "When the list is cleared".x(() =>
            {
                list.Clear();
            });

            "Then the list in empty".x(() =>
            {
                list.Head.ShouldBeNull();
                list.Tail.ShouldBeNull();
                list.Count.ShouldBe(0);
            });
        }
    }
}
