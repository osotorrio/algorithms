using System;

namespace Algorithms.Backtracking.NQueensProblem
{
    public class QueensOnChessBoard
    {
		public const int N = 8;

		public void FindByBacktracking(char[, ] mat, int r)
		{
			// if N queens are placed successfully, print the solution
			if (r == N)
			{
				PrintOutChessBoard(mat);
				return;
			}

			// place Queen at every square in current row r
			// and recur for each valid movement
			for (int i = 0; i < N; i++)
			{
				// if no two queens threaten each other
				if (IsSafe(mat, r, i))
				{
					// place queen on current square
					mat[r, i] = 'Q';

					// recur for next row
					FindByBacktracking(mat, r + 1);

					// backtrack and remove queen from current square
					mat[r, i] = '_';
				}
			}
		}

		private static bool IsSafe(char[,] mat, int r, int c)
		{
			// return false if two queens share the same column
			for (int i = 0; i < r; i++)
				if (mat[i, c] == 'Q')
					return false;

			// return false if two queens share the same \ diagonal
			for (int i = r, j = c; i >= 0 && j >= 0; i--, j--)
				if (mat[i, j] == 'Q')
					return false;

			// return false if two queens share the same / diagonal
			for (int i = r, j = c; i >= 0 && j < N; i--, j++)
				if (mat[i, j] == 'Q')
					return false;

			return true;
		}

		private static void PrintOutChessBoard(char[,] mat)
		{
			for (int i = 0; i < N; i++)
			{
				string row = string.Empty;

				for (int j = 0; j < N; j++)
				{
					row += $"{mat[i, j]} ";

					if (j == (N - 1))
					{
						Console.WriteLine(row);
					}

				}

				Console.WriteLine();
			}

			Console.WriteLine();
		}
	}
}
