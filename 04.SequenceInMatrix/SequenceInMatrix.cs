using System;

internal class SequenceInMatrix
{
    private static int maxLength;
    private static string currentElement;

    private static void Main()
    {
        Console.WriteLine("Please enter the number of the rows and the columns, separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');
        int inputRows = int.Parse(input[0]);
        int inputColumns = int.Parse(input[1]);

        Console.WriteLine("Please enter strings for the elements of the matrix, separated by a space: ");
        string[,] matrix = new string[inputRows, inputColumns];

        maxLength = int.MinValue;
        currentElement = "";

        for (int row = 0; row < inputRows; row++)
        {
            input = Console.ReadLine().Split(' ');
            for (int column = 0; column < inputColumns; column++)
            {
                matrix[row, column] = input[column];
            }
        }

        for (int i = 0; i < inputRows; i++)
        {
            for (int j = 0; j < inputColumns; j++)
            {
                CheckSet(CheckRow(matrix, matrix[i, j], i, j), matrix[i, j]);
                CheckSet(CheckColumn(matrix, matrix[i, j], i, j), matrix[i, j]);
                CheckSet(CheckRightDiagonal(matrix, matrix[i, j], i, j), matrix[i, j]);
                CheckSet(CheckLeftDiagonal(matrix, matrix[i, j], i, j), matrix[i, j]);
            }
        }

        PrintResult();
    }

    private static void CheckSet(int currentCounter, string currentString)
    {
        if (maxLength < currentCounter)
        {
            maxLength = currentCounter;
            currentElement = currentString;
        }
    }

    private static void PrintResult()
    {
        for (int i = 0; i < maxLength; i++)
        {
            if (i < maxLength - 1)
            {
                
                Console.Write(currentElement + ", ");
            }
            else
            {
                Console.WriteLine(currentElement);
            }
        }
    }

    private static int CheckRow(string[,] matrix, string current, int row, int column)
    {
        int counter = 0;
        for (int i = column; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == current)
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }

    private static int CheckColumn(string[,] matrix, string current, int row, int column)
    {
        int counter = 0;
        for (int i = row; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, column] == current)
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }

    private static int CheckRightDiagonal(string[,] matrix, string current, int row, int column)
    {
        int counter = 0;
        bool check = true;

        while (check)
        {
            if (matrix[row++, column++] == current)
            {
                counter++;
                if (column >= matrix.GetLength(1) || row >= matrix.GetLength(0))
                {
                    check = false;

                }
            }
            else
            {
                check = false;
            }
        }

        return counter;
    }

    private static int CheckLeftDiagonal(string[,] matrix, string current, int row, int column)
    {
        int counter = 0;
        bool check = true;

        while (check)
        {
            if (matrix[row++, column--] == current)
            {
                counter++;
                if (column < 0 || row >= matrix.GetLength(0))
                {
                    check = false;
                }
            }
            else
            {
                check = false;
            }

        }

        return counter;

    }
}
