using System;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое трехзначное число n, в котором число десятков не равно нулю: ");

            int n = int.Parse(Console.ReadLine());

            var number1 = n / 100;
            var number2 = (n/10) % 10
            var number3 = n % 10

            int x = number2 * 100 + number1 * 10 + number3; 

            Console.WriteLine("Первоначальное число x равно: " + x);

            Console.ReadKey();
        }
    }
}
