using Shouldly;
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
    }
}
