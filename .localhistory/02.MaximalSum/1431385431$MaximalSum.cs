using System;

// Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns. Print the elements of the 3 x 3 square as a matrix, along with their sum.
class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of the rows and the columns, separated by a space: ");
        string[] inputRowsAndColumns = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Please enter values for the elements, separated by a space, on each row: ");
        int rows = int.Parse(inputRowsAndColumns[0]);
        int columns = int.Parse(inputRowsAndColumns[1]);
        int[,] matrix = new int[rows + 1, columns + 1];
        for (int row = 0; row < rows; row++)
        {
            string[] currentRowNumbers =
                        Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = int.Parse(currentRowNumbers[col]);
            }
        }
 
        int bestSum = int.MinValue;
        int currentSum = 0;
        int[,] elementsWithMaxSum = new int[3, 3];
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < columns - 2; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    for (int i = 0; i < elementsWithMaxSum.GetLength(0); i++)
                    {
                        for (int j = 0; j < elementsWithMaxSum.GetLength(1); j++)
                        {
                            elementsWithMaxSum[i, j] = matrix[row + i, col + j];
                        }
                    }
                }
            }
        }
 
        Console.WriteLine("Sum = {0}", bestSum);
        for (int row = 0; row < elementsWithMaxSum.GetLength(0); row++)
        {
            for (int col = 0; col < elementsWithMaxSum.GetLength(1); col++)
            {
                Console.Write("{0,2} ", elementsWithMaxSum[row, col]);
            }
            Console.WriteLine();
        }
    }
}