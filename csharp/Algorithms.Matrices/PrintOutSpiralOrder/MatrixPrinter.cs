using System.Collections.Generic;

namespace Algorithms.Matrices.PrintOutSpiralOrder
{
    public class MatrixPrinter
    {
        public string PrintSpiralOrder(int[,] matrix)
        {
            var numbers = new List<int>();
            var left = 0;
            var top = 0;
            var right = matrix.GetLength(1) - 1;
            var bottom = matrix.GetLength(0) - 1;

            while (true)
            {
                numbers.AddRange(FromLeftToRight(matrix, left, right, top));
                top++;

                if (top > bottom) break;

                numbers.AddRange(FromTopToBottom(matrix, top, bottom, right));
                right--;

                numbers.AddRange(FromRightToLeft(matrix, right, left, bottom));
                bottom--;

                numbers.AddRange(FromBottomToTop(matrix, bottom, top, left));
                left++;

                if (left > bottom) break;
            }

            return string.Join(" ", numbers);
        }

        private static List<int> FromLeftToRight(int[,] matrix, int left, int right, int top)
        {
            var numbers = new List<int>();

            for (int i = left; i <= right; i++)
            {
                numbers.Add(matrix[top, i]);
            }

            return numbers;
        }

        private static List<int> FromTopToBottom(int[,] matrix, int top, int bottom, int right)
        {
            var numbers = new List<int>();

            for (int i = top; i <= bottom; i++)
            {
                numbers.Add(matrix[i, right]);
            }

            return numbers;
        }

        private static List<int> FromRightToLeft(int[,] matrix, int right, int left, int bottom)
        {
            var numbers = new List<int>();

            for (int i = right; i >= left; i--)
            {
                numbers.Add(matrix[bottom, i]);
            }

            return numbers;
        }

        private static List<int> FromBottomToTop(int[,] matrix, int bottom, int top, int left)
        {
            var numbers = new List<int>();

            for (int i = bottom; i >= top; i--)
            {
                numbers.Add(matrix[i, left]);
            }

            return numbers;
        }
    }
}
