using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы (NxM):");
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int m = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, m];

            Console.WriteLine("Введите элементы матрицы:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double mainDiagonalSum = GetMainDiagonalSum(matrix);
            double secondaryDiagonalSum = GetSecondaryDiagonalSum(matrix);

            Console.WriteLine($"Сумма элементов на главной диагонали: {mainDiagonalSum}");
            Console.WriteLine($"Сумма элементов на побочной диагонали: {secondaryDiagonalSum}");
        }

        static double GetMainDiagonalSum(double[,] matrix)
        {
            double sum = 0;
            int n = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        static double GetSecondaryDiagonalSum(double[,] matrix)
        {
            double sum = 0;
            int n = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, n - 1 - i];
            }
            return sum;
        }
    }
}
