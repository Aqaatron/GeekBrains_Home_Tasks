using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float min_temp;

            float max_temp;

            Console.Write("Введите минимальную температуру за сутки:");

            min_temp = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Введите максимальную температуру за сутки:");

            max_temp = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Среднесуточная температура:");

            float average_temp = (min_temp + max_temp) / 2;

            Console.Write(average_temp);

            Console.Read();

        }
    }
}
