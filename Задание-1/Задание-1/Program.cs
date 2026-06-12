using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Иосиф Бродский");

            Console.WriteLine(); 

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Натюрморт");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вещи и люди нас");
            Console.WriteLine("окружают. И те,");
            Console.WriteLine("и эти терзают глаз.");
            Console.WriteLine("Лучше жить в темноте.");

            Console.ResetColor();
        }
    }
}
