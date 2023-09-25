using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = myMatrix[i, j] * myMatrix[i, j]; // Square each element
            }
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] squareMatrix;
        int[,] myMatrix = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        squareMatrix = Matrix.Square(myMatrix);

        for (i = 0; i < squareMatrix.GetLength(0); i++)
        {
            for (j = 0; j < squareMatrix.GetLength(1); j++)
            {
                Console.Write(squareMatrix[i, j]);
                if (j != squareMatrix.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
