using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    enum Seasons
    {
        Summer = 1,
        Autumn,
        Winter,
        Spring
    }
    
    class Program
    {
        static void GetSeason(int num_of_month, out Seasons op)
        {
            if ((num_of_month  == 12) || (num_of_month == 1) || (num_of_month == 2))

                op = Seasons.Winter;

            else if ((num_of_month == 3) || (num_of_month == 4) || (num_of_month == 5))

                op = Seasons.Spring;

            else if ((num_of_month == 6) || (num_of_month == 7) || (num_of_month == 8))

                op = Seasons.Summer;
            else
                op = Seasons.Autumn;

        }

        static void Get_rus_season (ref Seasons season, out string rus_season)
        {
            switch (season)
            {
                case Seasons.Summer:
                    rus_season = "Лето";
                    break;
                case Seasons.Autumn:
                    rus_season = "Осень";
                    break;
                case Seasons.Winter:
                    rus_season = "Зима";
                    break;
                case Seasons.Spring:
                    rus_season = "Весна";
                    break;
                default:
                    rus_season = "Неверный номер месяца";
                    break;
            }
        }
        static void Main(string[] args)
        {
            Seasons cur_season;

            Console.WriteLine("Введите номер месяца");

            int num_of_month = Convert.ToInt16(Console.ReadLine());

            GetSeason(num_of_month, out cur_season);

            Get_rus_season(ref cur_season, out string cur_rus_season);

            Console.Write(cur_rus_season);

            Console.ReadLine();
        }
    }
}
