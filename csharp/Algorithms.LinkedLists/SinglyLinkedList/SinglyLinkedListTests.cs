using Shouldly;
using System;
using Xunit;

namespace Algorithms.LinkedLists.SinglyLinkedList
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void AddFirstWhenListEmptyTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();

            // Act
            var one = list.AddFirst("one");

            // Assert
            list.Count.ShouldBe(1);
            
            one.Value.ShouldBe("one");
            one.Next.ShouldBeNull();
            
            list.First.Value.ShouldBe("one");
            list.First.Next.ShouldBeNull();

            list.Last.Value.ShouldBe("one");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddFirstWhenListNoEmptyTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();
            var one = list.AddFirst("one");

            // Act
            var two = list.AddFirst("two");

            // Assert
            list.Count.ShouldBe(1);

            two.Value.ShouldBe("two");
            two.Next.ShouldBeNull();

            list.First.Value.ShouldBe("two");
            list.First.Next.ShouldBeNull();

            list.Last.Value.ShouldBe("two");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddLastWhenListEmptyTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();

            // Act
            var one = list.AddLast("one");

            // Assert
            list.Count.ShouldBe(1);

            one.Value.ShouldBe("one");
            one.Next.ShouldBeNull();

            list.First.Value.ShouldBe("one");
            list.First.Next.ShouldBeNull();

            list.Last.Value.ShouldBe("one");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddLastWhenListNoEmptyTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();
            var one = list.AddFirst("one");

            // Act
            var two = list.AddLast("two");

            // Assert
            list.Count.ShouldBe(2);

            two.Value.ShouldBe("two");
            two.Next.ShouldBeNull();

            list.First.Value.ShouldBe("one");
            list.First.Next.Value.ShouldBe("two");

            list.Last.Value.ShouldBe("two");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddAfterWhenListEmptyTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();

            // Act & Assert
            Should.Throw<InvalidOperationException>(() =>
            {
                list.AddBefore(list.First, "two");
            });
        }

        [Fact]
        public void AddAfterFirstWhenListHasOneItemTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();
            list.AddFirst("one");

            // Act
            var two = list.AddAfter(list.First, "two");

            // Arrange
            two.Value.ShouldBe("two");
            two.Next.ShouldBeNull();

            list.Count.ShouldBe(2);
            list.First.Value.ShouldBe("one");
            list.First.Next.Value.ShouldBe("two");
            list.First.Next.Next.ShouldBeNull();
            list.Last.Value.ShouldBe("two");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddAfterLastWhenListHasOneItemTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();
            list.AddFirst("one");

            // Act
            var two = list.AddAfter(list.Last, "two");

            // Arrange
            two.Value.ShouldBe("two");
            two.Next.ShouldBeNull();

            list.Count.ShouldBe(2);
            list.First.Value.ShouldBe("one");
            list.First.Next.Value.ShouldBe("two");
            list.First.Next.Next.ShouldBeNull();
            list.Last.Value.ShouldBe("two");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddAfterFirstWhenListHasTwoItemsTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();
            list.AddFirst("one");
            list.AddLast("three");

            // Act
            var two = list.AddAfter(list.First, "two");

            // Assert
            two.Value.ShouldBe("two");
            two.Next.Value.ShouldBe("three");
            two.Next.Next.ShouldBeNull();

            list.Count.ShouldBe(3);
            list.First.Value.ShouldBe("one");
            list.First.Next.Value.ShouldBe("two");
            list.First.Next.Next.Value.ShouldBe("three");
            list.First.Next.Next.Next.ShouldBeNull();
            list.Last.Value.ShouldBe("three");
            list.Last.Next.ShouldBeNull();
        }

        [Fact]
        public void AddAfterLastWhenListHasTwoItemsTest()
        {
            // Arrange
            var list = new SinglyLinkedList<string>();
            list.AddFirst("one");
            list.AddLast("two");

            // Act
            var three = list.AddAfter(list.Last, "three");

            // Assert
            three.Value.ShouldBe("three");
            three.Next.ShouldBeNull();

            list.Count.ShouldBe(3);
            list.First.Value.ShouldBe("one");
            list.First.Next.Value.ShouldBe("two");
            list.First.Next.Next.Value.ShouldBe("three");
            list.First.Next.Next.Next.ShouldBeNull();
            list.Last.Value.ShouldBe("three");
            list.Last.Next.ShouldBeNull();
        }
    }
}
