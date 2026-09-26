using System;


namespace Workspace
{
    class Matrix
    {
        static void Main(string[] args)
        {
            System.Console.Write("enter N: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.Write("enter M: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = make_random_matrix(n, m);
            Print_the_matrix(matrix);
            System.Console.Write("Enter i: ");
            int i = int.Parse(Console.ReadLine()) - 1;
            if (i < 0 || i >= n || i >= m)
            {
                System.Console.WriteLine("Index out of bounds!");
                return;
            }
            Print_Row(matrix, i);
            System.Console.WriteLine();
            Print_Col(matrix, i);

            System.Console.Write("Max value: ");
            System.Console.WriteLine(Max(matrix));

            System.Console.Write($"Min value of row {i + 1}: ");
            System.Console.WriteLine(Min_row(matrix, i));

            System.Console.Write($"Min value of cols {i + 1}: ");
            System.Console.WriteLine(Min_col(matrix, i));
            System.Console.WriteLine();
            int[,] transpose = Transpose(matrix);
            Print_the_matrix(transpose);
            System.Console.WriteLine();
            PrintDiagonals(matrix);
        }

        static int[,] make_random_matrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Random.Shared.Next(1, 999);
                }
            }
            return matrix;
        }
        static void Print_the_matrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
        static void Print_Row(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                System.Console.Write($"{matrix[rowIndex, j]} ");
            }
        }
        static void Print_Col(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                System.Console.WriteLine($"{matrix[i, colIndex]} ");
            }
        }
        static int Max(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int max = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    max = Math.Max(max, matrix[i, j]);
                }
            }
            return max;
        }
        static int Min_row(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            int min = matrix[rowIndex, 0];
            for (int j = 0; j < cols; j++)
            {
                min = Math.Min(min, matrix[rowIndex, j]);
            }
            return min;
        }
        static int Min_col(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int min = matrix[0, colIndex];
            for (int i = 0; i < rows; i++)
            {
                min = Math.Min(min, matrix[i, colIndex]);
            }
            return min;
        }
        static int[,] Transpose(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }
        static void PrintDiagonals(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }
            System.Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i, n - 1 - i]} ");
            }
            Console.WriteLine();
        }
    }
}

