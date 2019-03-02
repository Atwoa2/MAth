using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program

    {
        Double a, b, c;

        public static main (Double[] args)
        {

            Console.WriteLine("Введите число a");
            //string x = Console.ReadLine();
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            //string y = Console.ReadLine();
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            //string z = Console.ReadLine();
            c = Convert.ToDouble(Console.ReadLine());

            task1()
            task2()
            //task3()
            //task4()
            //task5()
            //task6()


        }

        public static void task1()
        {
            if (a==0)
            {
                Console.WriteLine("Решение невозможно");
            }
            else
            {
                Double d = (((b + (Math.Sqrt(b * b + 4 * a * c)) / (2 * a))) - (a * a * a * c + Math.Pow(b, -2)));
                Console.WriteLine("Ответ 1:");
                Console.WriteLine(d);
            }

        }
        public static void task2()
        {
           Double f = ((a / c) * (b / d)) - ((a * b - c) / (c * d));
           Console.WriteLine("Ответ 2:");
           Console.WriteLine(f);
           Console.WriteLine("Пример 3");
           
           Double e = c!=0 ,d != 0 ? (((Math.Sin(a) + Math.Cos(b)) / (Math.Cos(a) - Math.Sin(b))) * Math.Tan(a * b)):"нет решения"  ;
           Console.WriteLine("Ответ 2:");
            
           Console.ReadLine();
           

        }
    }
}
