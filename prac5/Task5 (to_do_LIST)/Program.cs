using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Collections;
using System.Xml.Serialization;

namespace Task5__to_do_LIST_
{
    class Program
    {
        static void Main(string[] args)
        {

            

            List<(string, bool)> my_ToDo_List = new List<(string, bool)>();

            ToDo my_ToDo = new ToDo(my_ToDo_List);


            
            my_ToDo.DeSeriaz("D:\\Обучение программированию\\Geek_Brains_new\\GeekBrains_Home_Tasks\\GeekBrains_Home_Tasks\\prac5\\Task5 (to_do_LIST)\\To_Do_List.xml");

            Console.WriteLine("Ваш список задач: ");

            my_ToDo.getList_console();

            Console.WriteLine("Хотите добавить задачу? (Введите Y/N)");

            string user_answer1 = Console.ReadLine();

            Console.WriteLine();

            if (user_answer1 == "Y")
            {
                Console.WriteLine("Введите названия задачи: ");


                string task_user_name = Console.ReadLine();

                my_ToDo.add_Do(task_user_name);

                Console.Clear();

                Console.WriteLine("Ваш обновлённый список задач: ");

                my_ToDo.getList_console();

            }

           

            Console.WriteLine("Хотите отметить выполненную задачу? (Введите Y/N)");

            string user_answer2 = Console.ReadLine();

            Console.WriteLine();

            if (user_answer2 == "Y")
            {
                Console.WriteLine("Введите номер задачи: ");


                int task_user_num = Convert.ToInt32(Console.ReadLine());

                my_ToDo.mark_Task(task_user_num);

                Console.Clear();

                Console.WriteLine("Ваш обновлённый список задач: ");

                my_ToDo.getList_console();

            }

            Console.WriteLine("Хотите удалить задачу? (Введите Y/N)");

            string user_answer3 = Console.ReadLine();

            Console.WriteLine();

            if (user_answer3 == "Y")
            {
                Console.WriteLine("Введите номер задачи: ");


                int task_user_num = Convert.ToInt32(Console.ReadLine());

                my_ToDo.delete_Task(task_user_num);

                Console.Clear();

                Console.WriteLine("Ваш обновлённый список задач: ");

                my_ToDo.getList_console();

            }


            my_ToDo.Seriaz("D:\\Обучение программированию\\Geek_Brains_new\\GeekBrains_Home_Tasks\\GeekBrains_Home_Tasks\\prac5\\Task5 (to_do_LIST)\\To_Do_List.xml");

            Console.ReadLine();

          

            

   






        }
    }
}
