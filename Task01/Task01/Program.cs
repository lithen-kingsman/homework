using System;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тучкины штучки";

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("'Тучкины штучки'" + " Владимир Маяковский");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Плыли по небу тучки.\r\nТучек - четыре штучки:\r\nот первой до третьей - люди;\r\nчетвертая была верблюдик.");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");


            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("К ним, любопытством объятая,\r\nпо дороге пристала пятая,\r\nот нее в небосинем лоне\r\nразбежались за слоником слоник.");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("И, не знаю, спугнула шестая ли,\r\nтучки взяли все - и растаяли.\r\nИ следом за ними, гонясь и сжирав,\r\nсолнце погналось - желтый жираф.");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
