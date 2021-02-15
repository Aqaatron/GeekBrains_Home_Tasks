using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int x = 10;
            //    int y = x / 0;

            //}
            //catch
            //{
            //    Console.WriteLine("Во время выполнения деления произошла ошибка");
            //}

            //Console.ReadLine();

            //Process notepad = Process.Start("notepad.exe", @"D:\some_file.txt");

            //notepad.WaitForExit();

            //Console.WriteLine(notepad.ExitCode);

            //Console.ReadLine();
            //D:\Обучение программированию\Geek_Brains_new\GeekBrains_Home_Tasks\GeekBrains_Home_Tasks\prac6\lesson6\bin\Debug\lesson6.exe

            //Process process = new Process();


            //process.StartInfo.FileName = @"D:\Обучение программированию\Geek_Brains_new\GeekBrains_Home_Tasks\GeekBrains_Home_Tasks\prac6\Calculator\bin\Debug\Calculator.exe";


            //process.StartInfo.Arguments = "1 2 3 4 5 6 7";

            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.RedirectStandardOutput = true;

            //process.Start();

            //string output = process.StandardOutput.ReadToEnd();

            //Console.WriteLine(output);

            //process.WaitForExit();

            //Console.WriteLine(process.ExitCode);

            //Console.ReadLine();

            Process[] process = Process.GetProcessesByName("notepad");

            Console.WriteLine(process);

            Console.ReadLine();

        }
        
        
    }
}
