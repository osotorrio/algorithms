using Shouldly;
using Xunit;

namespace Algorithms.Matrices.PrintOutSpiralOrder
{
    public class MatrixPrinterTests
    {
        [Fact]
        public void TwoRowsTwoColumnsMatrixTest()
        {
            // Arrange
            var printer = new MatrixPrinter();

            int[,] matrix = new int[2,2] 
            { 
                { 1, 2 }, 
                { 4, 3 } 
            };

            // Act
            var result = printer.PrintSpiralOrder(matrix);

            // Assert
            result.ShouldBe("1 2 3 4");
        }

        [Fact]
        public void ThreeRowsThreeColumnsMatrixTest()
        {
            // Arrange
            var printer = new MatrixPrinter();
            int[,] matrix = new int[3, 3] 
            { 
                { 1, 2, 3}, 
                { 8, 9, 4 }, 
                { 7, 6, 5 } 
            };

            // Act
            var result = printer.PrintSpiralOrder(matrix);

            // Assert
            result.ShouldBe("1 2 3 4 5 6 7 8 9");
        }

        [Fact]
        public void ThreeRowsFiveColumnsMatrixTest()
        {
            // Arrange
            var printer = new MatrixPrinter();

            int[,] matrix = new int[3, 5] 
            { 
                { 1, 2, 3, 4, 5 }, 
                { 12, 13, 14, 15, 6 }, 
                { 11, 10, 9, 8, 7 } 
            };

            // Act
            var result = printer.PrintSpiralOrder(matrix);

            // Assert
            result.ShouldBe("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15");
        }

        [Fact]
        public void FourRowsThreeColumnsMatrixTest()
        {
            // Arrange
            var printer = new MatrixPrinter();

            int[,] matrix = new int[4, 3]
            {
                { 1, 2, 3 },
                { 10, 11, 4 },
                { 9, 12, 5 },
                { 8, 7, 6 }
            };

            // Act
            var result = printer.PrintSpiralOrder(matrix);

            // Assert
            result.ShouldBe("1 2 3 4 5 6 7 8 9 10 11 12");
        }

        [Fact]
        public void FiveRowsFiveColumnsMatrixTest()
        {
            // Arrange
            var printer = new MatrixPrinter();

            int[,] matrix = new int[5, 5] 
            {
                { 1,  2,  3,  4, 5 },
                { 16, 17, 18, 19, 6 },
                { 15, 24, 25, 20, 7 },
                { 14, 23, 22, 21, 8 },
                { 13, 12, 11, 10, 9 }
            };

            // Act
            var result = printer.PrintSpiralOrder(matrix);

            // Assert
            result.ShouldBe("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25");
        }
    }
}
