using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_Manager
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            Console.WriteLine("Список запущенных процессов: ");

            foreach (Process proc in processes)
            {
                Console.WriteLine(proc.ProcessName + " " +  proc.Id);
            }
            

            Console.WriteLine("Хотите удалить процесс? (Введите Y/N)");


            string user_answer = Console.ReadLine();

            if (user_answer == "Y")
            {
                Console.WriteLine("Вы хотите удалить процесс по его имени? (Введите Y/N)");

                user_answer = Console.ReadLine();
            }


            if (user_answer == "Y")

            {   
                Console.WriteLine("Введите имя процесса: ");

                user_answer = Console.ReadLine();

                foreach (Process proc in processes)
                {
                    if (proc.ProcessName == user_answer)
                    { 
                        try
                        {
                            proc.Kill();
                        }
                        catch
                        {
                                Console.WriteLine("Нет доступа к процессу!");
                        }
                    }

                }

            }
               
                
            Console.WriteLine("Вы хотите удалить процесс по его Id? (Введите Y/N)");

            user_answer = Console.ReadLine();

            if (user_answer == "Y")
            {
                Console.WriteLine("Введите Id процесса: ");

                user_answer = Console.ReadLine();

                foreach (Process proc in processes)
                {
                    if (proc.Id == Convert.ToInt32(user_answer))
                    {
                        try
                        {
                            proc.Kill();
                        }
                        catch
                        {
                            Console.WriteLine("Нет доступа к процессу!");
                        }
                    }
                        
                }

                    
            }

            
            
            //Console.WriteLine("Текущий список процессов: ");

            //foreach (Process proc in processes)
            //{
            //    Console.WriteLine(proc.ProcessName + " " + proc.Id);
            //}

            Console.ReadLine();
        }
    }
}
