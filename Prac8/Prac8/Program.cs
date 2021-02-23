using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac8
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Хотите ли Вы сбросить пользовательские настройки? (Введите Y/N)");



            string user_asnwer = Console.ReadLine();

            if (user_asnwer == "Y")
                Properties.Settings.Default.Reset(); 

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите Ваше имя:");

                Properties.Settings.Default.UserName = Console.ReadLine();

                Console.WriteLine("Введите Ваш возраст:");

                Properties.Settings.Default.UserAge = Console.ReadLine();

                Console.WriteLine("Введите Ваш род деятельности:");

                Properties.Settings.Default.UserWork = Console.ReadLine();

                Properties.Settings.Default.Save();
            }
            

            Console.WriteLine($"Ваше имя: {Properties.Settings.Default.UserName}, Ваш возраст: {Properties.Settings.Default.UserAge}, Ваш род деятельности: {Properties.Settings.Default.UserWork}");

            Console.ReadLine();

        }
    }
}
