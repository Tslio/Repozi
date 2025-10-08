using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(3, 11) + Calculate(5, 13) + Calculate(7, 17);
            Console.WriteLine(Math.Round(x, 3));
        }

        static double Calculate(double a, double b) =>
            (1 + a * a) / (1 + b * b);
    }
}
