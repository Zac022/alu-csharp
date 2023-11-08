using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square (equal number of rows and columns)
        if (rows != cols)
        {
            // Return a matrix containing -1 for invalid size
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the rotated values
        double[,] rotatedMatrix = new double[rows, cols];

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Apply rotation to each element in the matrix
                double x = i - rows / 2.0;
                double y = j - cols / 2.0;
                double newX = x * cosTheta - y * sinTheta + rows / 2.0;
                double newY = x * sinTheta + y * cosTheta + cols / 2.0;

                // Check if the new coordinates are within the matrix bounds
                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
                {
                    rotatedMatrix[i, j] = matrix[(int)newX, (int)newY];
                }
                else
                {
                    // If the new coordinates are out of bounds, set the value to -1
                    rotatedMatrix[i, j] = -1;
                }
            }
        }

        return rotatedMatrix;
    }
}
