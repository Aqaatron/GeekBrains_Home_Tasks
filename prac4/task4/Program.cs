using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static double Fibonachi(int n)
        {
            if (n == 0)

                return 0;

            if (n == 1)

                return 1;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static void Main(string[] args)
        {

            Console.Write("Введите число n: ");


            int n = Convert.ToInt16(Console.ReadLine());



            Console.WriteLine($"Число Фибоначи под номером n : {Fibonachi(n)}");

            Console.ReadLine();
        }
    }
}
