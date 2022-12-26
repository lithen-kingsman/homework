using System;
using System.Linq.Expressions;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");

            double x = 0;

            try
            {
               x = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            var y = Math.Sqrt(x * x + Math.Sqrt(x * x + 1 / (x * x)));

            Console.WriteLine("Значение значение функции y = f(x) равно:" + y);

            Console.ReadKey();

        }
    }
}
