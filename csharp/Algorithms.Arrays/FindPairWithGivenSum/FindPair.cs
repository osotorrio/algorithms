namespace Algorithms.Arrays.FindPairWithGivenSum
{
    public class FindPair
    {
        // Complexity analysis: O(n^2) 
        internal dynamic FindByBruteForce(int sum, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        return new { v1 = arr[i], v2 = arr[j], i, j };
                    }
                }
            }

            return new { v1 = 0, v2 = 0, i = 0, j = 0 };
        }
    }
}
