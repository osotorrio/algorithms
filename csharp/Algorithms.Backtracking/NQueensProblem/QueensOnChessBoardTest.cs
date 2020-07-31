
using Xunit;

namespace Algorithms.Backtracking.NQueensProblem
{
    public class QueensOnChessBoardTest
    {
        [Fact]
        public void Monkey()
        {
            var solution = new QueensOnChessBoard();

            char[,] mat = new char[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    mat[i, j] = '_';
                }
            }

            solution.FindByBacktracking(mat, 0);
        }
    }
}
