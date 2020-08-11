using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Algorithms.LinkedLists.SinglyLinkedList
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void AddFirstEmptyListTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();

            // Act
            var node = list.AddFirst("one");

            // Assert
            list.Count.ShouldBe(1);
            
            node.Value.ShouldBe("one");
            node.Next.ShouldBeNull();
            
            list.First.Value.ShouldBe("one");
            list.First.Next.ShouldBeNull();

            list.Last.Value.ShouldBe("one");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddLastEmptyListTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();

            // Act
            var node = list.AddLast("one");

            // Assert
            list.Count.ShouldBe(1);

            node.Value.ShouldBe("one");
            node.Next.ShouldBeNull();

            list.First.Value.ShouldBe("one");
            list.First.Next.ShouldBeNull();

            list.Last.Value.ShouldBe("one");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void Monkey()
        {
            var list = new LinkedList<string>();

            var first = list.AddFirst("one");
            list.AddLast("three");


            var first2 = list.AddAfter(first, "one");

            var newFirst = new LinkedListNode<string>("one");

            list.AddAfter(newFirst, "two");
        }
    }
}
