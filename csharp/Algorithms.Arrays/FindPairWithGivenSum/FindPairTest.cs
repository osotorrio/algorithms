using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Arrays.FindPairWithGivenSum
{
    public class FindPairTest
    {
        [Theory]
        [InlineData(15, new[] { 2, 10, 4, 5, 7, 6, 3, 1, 9, 12 })]
        public void FindByBruteForceTest(int sum, int[] arr)
        {
            // Arrange
            var expectedIndex1 = 1;
            var expectedIndex2 = 3;
            
            var findPair = new FindPair();

            // Act  
            var pair = findPair.FindByBruteForce(sum, arr);

            // Assert
            Assert.Equal(expectedIndex1, pair.Index1);
            Assert.Equal(expectedIndex2, pair.Index2);
        }

        [Theory]
        [InlineData(15, new[] { 2, 10, 4, 5, 7, 6, 3, 1, 9, 12 })]
        public void FindBySortingTest(int sum, int[] arr)
        {
            // Arrange
            // [1, 2, 3, 4, 5, 6, 7, 9, 10, 12]
            var expectedIndex1 = 2;
            var expectedIndex2 = 9;

            var findPair = new FindPair();

            // Act  
            var pair = findPair.FindBySorting(sum, arr);

            // Assert
            Assert.Equal(expectedIndex1, pair.Index1);
            Assert.Equal(expectedIndex2, pair.Index2);
        }
    }
}
