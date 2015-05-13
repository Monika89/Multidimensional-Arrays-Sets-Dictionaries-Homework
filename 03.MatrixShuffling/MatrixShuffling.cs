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

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        string input;
        string[] command;
        while (!((input = Console.ReadLine()) == "END"))
        {
            command = input.Split(' ');
            if (command.Length == 5 && command[0] == "swap")
            {
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);
                string temp;
                if ((row1 >= 0 && row1 < inputRows) && (row2 >= 0 && row2 < inputRows) && (col1 >= 0 && col1 < inputColumns) && (col2 >= 0 && col2 < inputColumns))
                {
                    temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write("{0,2} ", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}