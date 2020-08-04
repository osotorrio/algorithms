using Shouldly;
using Xunit;

namespace Algorithms.Stacks.CheckBalancedExpression
{
    public class CheckBalancedExpressionTest
    {
        [Theory]
        [InlineData("()")]
        [InlineData("{{}{}}")]
        [InlineData("[]{}()")]
        [InlineData("{[{}{}]}[()]")]
        public void CheckReturnsTrue(string expression)
        {
            // Arrange
            var checker = new ExpressionChecker();

            // Act
            var isBalanced = checker.IsBalanced(expression);

            // Assert
            isBalanced.ShouldBeTrue();
        }

        [Theory]
        [InlineData("{")]
        [InlineData("]")]
        [InlineData("][")]
        [InlineData("])")] 
        [InlineData("[(")]
        [InlineData("[)")]
        [InlineData("{(})")]
        [InlineData("{()}[)")]
        public void CheckReturnsFalse(string expression)
        {
            // Arrange
            var checker = new ExpressionChecker();

            // Act
            var isBalanced = checker.IsBalanced(expression);

            // Assert
            isBalanced.ShouldBeFalse();
        }
    }
}
