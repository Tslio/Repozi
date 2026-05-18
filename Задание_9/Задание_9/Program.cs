using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"f({x:F2}) = {F(x):F2}");
        }

        static double F(double x)
        {
            if (Math.Abs(x) < Math.PI / 4)
                return Math.Atan(x);
            else if (x >= Math.PI / 4)
                return 1;
            else
                return -1;
        }
    }
}
