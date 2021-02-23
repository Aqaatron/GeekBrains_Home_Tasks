using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static int Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += Convert.ToInt32(args[i]);
            }
            Console.Write(sum);

            return -sum;
        }
    }
}
