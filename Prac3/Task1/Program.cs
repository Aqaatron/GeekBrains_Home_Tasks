using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int[,] GetRandomArray(int rows, int colums)
        {
            Random random = new Random();
            var result = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    result[i, j] = random.Next(10);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int rows = 5;
            int colums = 5;
            int[,] myarray = GetRandomArray(rows, colums);

            Console.Write("Исходный массив: ");

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < colums; j++)
                {

                    Console.Write(myarray[i, j] + " ");
                }
            }

            Console.WriteLine();

            Console.Write("Диагональ: ");

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < colums; j++)
                {
                    if (j == i)
                        Console.Write(myarray[i, j] + " ");
                }
            }


            Console.Read();

        }
    }
}
