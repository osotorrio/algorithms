using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Arrays.FindPairWithGivenSum
{
    public class FindPairTest
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void FindTests(int sum, int[] arr, dynamic expected)
        {
            // Arrange
            var findPair = new FindPair();

            // Act  
            var pairs = findPair.FindByBruteForce(sum, arr);

            // Assert
            Assert.Equal(expected.v1, pairs.v1);
            Assert.Equal(expected.v2, pairs.v2);
            Assert.Equal(expected.i, pairs.i);
            Assert.Equal(expected.j, pairs.j);
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]
                {
                    10,
                    new[] { 8, 7, 2, 5, 3, 1 },
                    new { v1 = 8, v2 = 2, i = 0, j = 2 }
                },
                new object[]
                {
                    15,
                    new[] { 2, 10, 4, 5, 7, 6, 3, 1, 9, 12 },
                    new { v1 = 10, v2 = 5, i = 1, j = 3 }
                },
                new object[]
                {
                    5,
                    new[] { 6, 1, 4, 3, 8, 5, 9, 7 },
                    new { v1 = 1, v2 = 4, i = 1, j = 2 }
                }
            };
    }
}
