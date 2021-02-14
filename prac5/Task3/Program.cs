using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task3
{
    [Serializable]
    class Program

    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Введите любую последовательность чисел от 0 до 255: ");


            string user_numbers = Console.ReadLine();

            string[] num = user_numbers.Split(' ');

            BinaryFormatter formatter = new BinaryFormatter();



            formatter.Serialize(new FileStream("my.bin", FileMode.OpenOrCreate), num);



            Console.WriteLine("Последовательность чисел записана в бинарный файл!!!");

            Console.ReadLine();
        }
    }
}
