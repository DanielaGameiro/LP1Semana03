using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float[,] matrix;
            int rows, cols;
            float[] sumOfRows;
            float[] sumOfCols;

            // Ask user for array dimensions
            Console.WriteLine("Number of rows: ");
            rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of cols: ");
            cols = int.Parse(Console.ReadLine());

            // Array with the sizes given
            matrix = new float[rows, cols];

            // Ask the user for a number to put in each position
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.WriteLine($"Value in ({r}, {c}): ");
                    matrix[r, c] = float.Parse(Console.ReadLine());
                }
            }

            // Calculate the sum of the rows and show it
            sumOfRows = new float[rows];

            for (int r = 0; r < rows; r++)
            {
                float rowSum = 0;

                for (int c = 0; c < cols; c++)
                {
                    rowSum += matrix[r, c];
                }

                Console.WriteLine($"Sum of row {r} : {rowSum}");
                sumOfRows[r] = rowSum;
            }

            // Calculate the sum of the cols and show it
            sumOfCols = new float[cols];

            for (int c = 0; c < cols; c++)
            {
                float colSum = 0;

                for (int r = 0; r < rows; r++)
                {
                    colSum += matrix[r, c];
                }

                Console.WriteLine($"Sum of col {c} : {colSum}");
                sumOfCols[c] = colSum;
            }
        }
    }
}

