using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        enum Days_of_week
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            Console.Write("Введите  порядковый номер месяца: ");

            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите температуру: ");

            int temp = int.Parse(Console.ReadLine());


            if ( (temp > 0 && ( (Days_of_week)month == (Days_of_week.Январь) )) || ( temp > 0 && ((Days_of_week)month == (Days_of_week.Февраль) ) ) || (temp > 0 && ((Days_of_week)month == (Days_of_week.Декабрь))))

            
                Console.WriteLine("Дождливая зима");
            
            else
                Console.WriteLine("Ничего не выводить");


            Console.Read();
        }
    }
}
