using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример 1");
            Console.WriteLine("Ввыедите число a");
            string x = Console.ReadLine();
            Double a = Convert.ToDouble(x);
            Console.WriteLine("Ввыедите число b");
            string y = Console.ReadLine();
            Double b = Convert.ToDouble(y);
            Console.WriteLine("Ввыедите число c");
            string z = Console.ReadLine();
            Double c = Convert.ToDouble(z);

            Double d = (((b + (Math.Sqrt(b * b + 4 * a * c)) / (2 * a))) - (a * a * a * c + Math.Pow(b, -2)));
            Console.WriteLine("Ответ 1:");
            Console.WriteLine(d);
            Console.WriteLine("Пример 2");

            Double f = ((a / c) * (b / d)) - ((a * b - c) / (c * d));
            Console.WriteLine("Ответ 2:");
            Console.WriteLine(f);

            Console.WriteLine("Пример 3");

            Double e = ((Math.Sin(a) + Math.Cos(b)) / (Math.Cos(a) - Math.Sin(b))) * Math.Tan(a * b);

            Console.WriteLine("Ответ 2:");
            Console.WriteLine(e);

            Console.ReadLine();



        }
    }
}