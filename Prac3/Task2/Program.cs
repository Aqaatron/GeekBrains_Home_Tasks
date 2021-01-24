using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] contacts = { { "Андрей", "+79276353456" },
                                    {"Михаил" , "89376343221"},
                                    {"Александр", "+79053224556" },
                                    {"Петр", "89093310345" },
                                    {"Ксения", "+79216547656"}
                                                            };

            Console.Write("Введите имя контакта из справочника: ");
            string user_contact = Console.ReadLine();

            int j = 0;
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (contacts[i, j] == user_contact)
                {
                    Console.WriteLine($"Номер абонента: {contacts[i, j + 1]}");
                    k++;
                }
                       
            }

            if (k ==0)
                Console.WriteLine("Такого контакта не существует в справочнике");



            

           

            Console.Read();
        }
    }
}
