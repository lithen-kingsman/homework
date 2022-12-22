using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны ромба:");
            double a = double.Parse (Console.ReadLine());
            double P = a * 4;

            Console.WriteLine("Введите градусную меру угла между смежными сторонами ромба:");
            double v = double.Parse (Console.ReadLine());
            double v2 = Math.PI * v / 180;
            double v1 = v2;
            double S = Math.Sin(v1) * a * a;

            Console.WriteLine("Периметр ромба равен: " + P);
            Console.WriteLine("Площадь ромба равна: " + S);

            Console.ReadKey();


        }
    }
}
