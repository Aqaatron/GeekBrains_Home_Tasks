using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "user_text.txt";

            Console.Write("Введите текст для записи в файл: ");

            string user_text = Console.ReadLine();

            File.WriteAllText(filename, user_text);

            Console.ReadLine();

        }
    }
}
