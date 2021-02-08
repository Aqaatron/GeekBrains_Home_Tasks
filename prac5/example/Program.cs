using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings CDS = new Buildings(15, 7);

            //CDS.Adress = "agasga";

            CDS.ChangeAdress("agasgasasgsa");

            Console.WriteLine(CDS.Adress);

            Console.ReadLine();

        }
    }
}
