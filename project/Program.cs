using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__3_
{
    internal class Program
    {
        static int[,] inputmatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];
            Console.WriteLine("Enter the value of matrix row vise");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }
        static void Displaymatrix(int[,] matrix)
        {
            Console.WriteLine("Element of matrix is "); for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
        static void CalculateRowColumnSums(int[,] matrix)
        {


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sumofrow = 0; for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sumofrow += matrix[i, j];

                }
                Console.WriteLine($"sum of {i + 1} row is {sumofrow}");
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sumofcolumn = 0; for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sumofcolumn += matrix[j, i];

                }
                Console.WriteLine($"sum of {i + 1} column is {sumofcolumn}");

            }

        }
        static void FindMaxElement(int[,] matrix)
        {
            int max = int.MinValue; for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Max value is {max}");

        }
        static void FindMinElement(int[,] matrix)
        {
            int min = int.MaxValue; for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Minmum value is {min}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of rows of matrix"); int row = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Enter no of column of matrix"); int column = Convert.ToInt32(Console.ReadLine()); int[,] matrix = new int[row, column]; matrix = inputmatrix(row, column); while (true)
            {
                Console.WriteLine("1. Display matrix");
                Console.WriteLine("2. Calculate Row and Column Sums");
                Console.WriteLine("3. Find Maximum Element");
                Console.WriteLine("4. Find Minimum Element"); Console.WriteLine("5. Excit"); int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Displaymatrix(matrix); break;
                        }
                    case 2:
                        {
                            CalculateRowColumnSums(matrix);
                            break;
                        }
                    case 3:
                        {
                            FindMaxElement(matrix);
                            break;
                        }
                    case 4:
                        {
                            FindMinElement(matrix);
                            break;
                        }
                    case 5:
                        {
                            return; break;
                        }
                    default:
                        {
                            Console.WriteLine("You enter invalid value"); break;
                        }
                }
            }
        }
    }
}


