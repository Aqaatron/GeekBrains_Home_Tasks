using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя кассира: ");

            string teller = Console.ReadLine(); //имя кассира

            Console.Write("Введите стоимость колбасы: ");

            float product1 = float.Parse(Console.ReadLine());

            Console.Write("Введите стоимость молока: ");

            float product2 = float.Parse(Console.ReadLine());

            Console.Write("Введите стоимость соли: ");

            float product3 = float.Parse(Console.ReadLine());

            Console.Write("Введите размер скидки: ");

            float sale = float.Parse(Console.ReadLine());

            Console.Write("Введите количество наличных: ");

            float cash = float.Parse(Console.ReadLine()); ;


            Console.WriteLine();

            Console.WriteLine("жжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжж");

            Console.WriteLine("Чек ПРОДАЖА № 9999.2.407.518");

            Console.WriteLine("Касса № 2");

            Console.Write(DateTime.Now);

            Console.WriteLine(" " + teller);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("1 Колбаса вареная Молочн         =" + product1);

            Console.WriteLine("2 Молоко Сибирская Милена        =" + product2);

            Console.WriteLine("3 Соль Илецкая поваренная        =" + product3);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("ИТОГО без скидок:                " + (product1 + product2 + product3));

            Console.WriteLine("ИТОГО скидок:                    " + sale);

            Console.WriteLine("ИТОГО с учётом скидок:           " + (product1 + product2 + product3 - sale));

            Console.WriteLine("ВНЕСЕНО:                         " + cash);

            Console.WriteLine("Cдача:                           " + (cash - (product1 + product2 + product3 - sale)));

            Console.WriteLine();
            
            Console.WriteLine("          СПАСИБО ЗА ПОКУПКУ!");

            Console.WriteLine("жжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжжж");

            Console.Read();
        }
    }
}
