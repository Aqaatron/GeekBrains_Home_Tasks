using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            double sum = 0; ;

            string[] num  = numbers.Split(' ');

            foreach (var i in num)
            {
                 sum = sum + Convert.ToDouble(i);
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
