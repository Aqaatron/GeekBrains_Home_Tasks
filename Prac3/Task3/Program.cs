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
            Console.Write("Ввведите строку: ");

            string user_string = Console.ReadLine();

            for (int i = user_string.Length - 1; i > -1; i--)
                {
                    Console.Write(user_string[i]);
                }

            Console.ReadLine();
        }
    }
}
