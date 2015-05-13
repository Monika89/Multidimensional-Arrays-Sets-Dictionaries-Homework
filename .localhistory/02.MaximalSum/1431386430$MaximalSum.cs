using System;

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
        int sum = 0;
        int[,] insideMatrix = new int[3, 3];
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < columns - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    for (int i = 0; i < insideMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < insideMatrix.GetLength(1); j++)
                        {
                            insideMatrix[i, j] = matrix[row + i, col + j];
                        }
                    }
                }
            }
        }
 
        Console.WriteLine("Sum = {0}", bestSum);
        for (int row = 0; row < insideMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < insideMatrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", insideMatrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}