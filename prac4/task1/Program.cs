using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    
        class Program
        {
            static string GetFullName(params string[] sepname)
            {

                string fullname = "";

                for (int i = 0; i < sepname.Length; i++)
                {

                    fullname = fullname + sepname[i] + " ";
                }
                return fullname;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите Фамилию:");

                string secondname = Console.ReadLine();


                Console.WriteLine("Введите Имя");

                string fistname = Console.ReadLine();



                Console.WriteLine("Введите Отчество");

                string patronymic = Console.ReadLine();

                Console.WriteLine(GetFullName(secondname, fistname, patronymic));

                Console.ReadLine();
            }
        }
    }

