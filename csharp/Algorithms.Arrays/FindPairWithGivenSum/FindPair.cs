using System;

namespace Algorithms.Arrays.FindPairWithGivenSum
{
    public class FindPair
    {
        internal class Pair
        {
            public int Index1 { get; set; }
            public int Index2 { get; set; }
        }

        // Complexity analysis: O(n^2) 
        internal Pair FindByBruteForce(int sum, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        return new Pair { Index1 = i, Index2 = j };
                    }
                }
            }

            return new Pair { Index1 = 0, Index2 = 0 };
        }

        internal Pair FindBySorting(int sum, int[] arr)
        {
            Array.Sort(arr);

            var low = 0;
            var high = arr.Length - 1;

            while (low < high)
            {
                if (arr[low] + arr[high] == sum)
                {
                    return new Pair { Index1 = low, Index2 = high };
                }

                if (arr[low] + arr[high] < sum) low++;
                if (arr[low] + arr[high] > sum) high--;
            }

            return new Pair { Index1 = 0, Index2 = 0 };
        }
    }
}
