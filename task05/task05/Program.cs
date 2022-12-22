using System;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Summand (double a, double b, double c)

            { double summand = Math.Sqrt((a + Math.Tan(b) * Math.Tan(b)) / c);

                return summand;
            }

            double x1 = 1, y1 = 2, z1 = 3;
            double firstsummand = Summand (x1, y1, z1);

            double x2 = 5, y2 = 3, z2 = 8;
            double secondsummand = Summand(x2, y2, z2);

            double x3 = 1, y3 = 5, z3 = 6;
            double thirdsummand = Summand(x3, y3, z3);

            double x = firstsummand + secondsummand + thirdsummand;

            Console.WriteLine("Значение x равно:" + x);

            Console.ReadKey();





        }
    }
}
