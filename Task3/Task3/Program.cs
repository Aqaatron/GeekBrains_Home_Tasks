using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            int user_number = int.Parse(Console.ReadLine());

            if (user_number % 2 == 0)
                Console.WriteLine("Введёное число чётное");
            else
                Console.WriteLine("Введёное число нечётное");

            Console.Read();
        }
    }
}
