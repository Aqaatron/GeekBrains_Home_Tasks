using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";

            File.AppendAllText( filename, Convert.ToString( DateTime.Now.ToLongTimeString() ) + "\n");

           
        }
    }
}
