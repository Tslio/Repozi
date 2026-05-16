using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание10._3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1;

            while (i * i < n)
            {
                i++;
            }

            int i2 = i - 1;

            Console.WriteLine("Наибольшее натуральное число, квадрат которого меньше n: " + i2);
        }
    }
}
   