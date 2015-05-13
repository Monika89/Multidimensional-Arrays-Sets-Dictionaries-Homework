using System;

// Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern (top to bottom and left to right) is boring.

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Please enter the size of the matrix: ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int count = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = count;
                count++;
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}