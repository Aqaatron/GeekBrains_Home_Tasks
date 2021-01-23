using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        enum Days_of_week
        {
            Понедельник = 1,
            Вторник, 
            Среда, 
            Четверг, 
            Пятница, 
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер дня недели: ");

            int days_number_user = int.Parse(Console.ReadLine());

            switch (days_number_user)
            {
                case 1:
                    Console.WriteLine("Сегодня: " + Days_of_week.Понедельник);
                    break;
                case 2:
                    Console.WriteLine("Сегодня: " + Days_of_week.Вторник);
                    break;
                case 3:
                    Console.WriteLine("Сегодня: " + Days_of_week.Среда);
                    break;
                case 4:
                    Console.WriteLine("Сегодня: " + Days_of_week.Четверг);
                    break;
                case 5:
                    Console.WriteLine("Сегодня: " + Days_of_week.Пятница);
                    break;
                case 6:
                    Console.WriteLine("Сегодня: " + Days_of_week.Суббота);
                    break;
                case 7:
                    Console.WriteLine("Сегодня: " + Days_of_week.Воскресенье);
                    break;
                default:
                    break;
            }





            Console.Read();
        }
    }
}
