using System;

class MatrixShuffling
{
    static void Main()
    {
        Console.Write("Please enter the number of the rows: ");
        int inputRows = int.Parse(Console.ReadLine());

        Console.Write("Please enter the number of the columns: ");
        int inputColumns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[inputRows, inputColumns];

        for (int i = 0; i < inputRows; i++)
        {
            for (int j = 0; j < inputColumns; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
    }
}