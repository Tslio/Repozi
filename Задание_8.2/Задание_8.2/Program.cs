using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абциссу точки");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            var y = double.Parse(Console.ReadLine());

            if (IsInArea(x, y))
                Console.WriteLine("Точка лежит в указанной области.");
            else
                Console.WriteLine("Точка не лежит в указанной области.");

        }

        static bool IsInArea(double x, double y) =>
            (y >= 1 && x <= -2);
    }
}
