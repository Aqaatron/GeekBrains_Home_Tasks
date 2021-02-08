using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace write_and_read_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "same.txt";

            File.WriteAllText(filename, "Привет");



        }
    }
}
