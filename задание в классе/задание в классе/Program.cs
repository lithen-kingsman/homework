using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_в_классе
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            double angle1 = 15 * Math.PI / 180;
            Console.WriteLine("Синус 15 градусов равен: " + Math.Round(Math.Sin(angle1), 3));
            Console.WriteLine("Косинус 15 градусов равен: " + Math.Round(Math.Cos(angle1), 3));

            Console.WriteLine();

            double angle2 = 37 * Math.PI / 180;
            Console.WriteLine("Синус 37 градусов равен: " + Math.Round(Math.Sin(angle2), 3));
            Console.WriteLine("Косинус 37 градусов равен: " + Math.Round(Math.Cos(angle2), 3));

            Console.WriteLine();

            double angle3 = 113 * Math.PI / 180;
            Console.WriteLine("Синус 113 градусов равен: " + Math.Round(Math.Sin(angle3), 3));
            Console.WriteLine("Косинус 113 градусов равен: " + Math.Round(Math.Cos(angle3), 3));
            Console.ReadKey();
        }
    }
}
