using System;

class MatrixAddition
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = int.Parse(Console.ReadLine());

        int[,] ary1 = new int[rows, cols];
        int[,] ary2 = new int[rows, cols];
        int[,] sum = new int[rows, cols];

        Console.WriteLine("Enter elements for Matrix 1:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"ary1[{i},{j}]: ");
                ary1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements for Matrix 2:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"ary2[{i},{j}]: ");
                ary2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Sum of the two matrices:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum[i, j] = ary1[i, j] + ary2[i, j];
                Console.Write(sum[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
