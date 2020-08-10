using Shouldly;
using Xunit;

namespace Algorithms.Strings.ReverseStringRecursion
{
    public class ReverseStringTest
    {
        [Fact]
        public void ReverseEvenStringBySwapRecursionTest()
        {
            var input = "Karpov";

            var reverser = new StringReversion();

            var output = reverser.ReverseBySwapRecursion(input);

            output.ShouldBe("vopraK");
        }

        [Fact]
        public void ReverseOddStringBySwapRecursionTest()
        {
            var input = "Fischer";

            var reverser = new StringReversion();

            var output = reverser.ReverseBySwapRecursion(input);

            output.ShouldBe("rehcsiF");
        }

        [Fact]
        public void ReverseByStackTest()
        {
            var input = "Let's reverse a string";

            var reverser = new StringReversion();

            var output = reverser.ReverseByStack(input);

            output.ShouldBe("gnirts a esrever s'teL");
        }

        [Fact]
        public void ReverseStringByRecursionArrayTest()
        {
            var input = "Let's reverse a string";

            var reverser = new StringReversion();

            var output = reverser.ReverseByArrayRecursion(input);

            output.ShouldBe("gnirts a esrever s'teL");
        }
    }
}
