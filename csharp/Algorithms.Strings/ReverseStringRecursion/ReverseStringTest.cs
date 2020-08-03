using Shouldly;
using Xunit;

namespace Algorithms.Strings.ReverseStringRecursion
{
    public class ReverseStringTest
    {
        [Fact]
        public void ReverseEvenStringByRecursionTest()
        {
            var input = "Karpov";

            var reverser = new StringReverser();

            var output = reverser.ReverseRecursion(input);

            output.ShouldBe("vopraK");
        }

        [Fact]
        public void ReverseOddStringByRecursionTest()
        {
            var input = "Fischer";

            var reverser = new StringReverser();

            var output = reverser.ReverseRecursion(input);

            output.ShouldBe("rehcsiF");
        }

        [Fact]
        public void ReverseStringByRecursionTest()
        {
            var input = "Let's reverse a string";

            var reverser = new StringReverser();

            var output = reverser.ReverseRecursion(input);

            output.ShouldBe("gnirts a esrever s'teL");
        }
    }
}
