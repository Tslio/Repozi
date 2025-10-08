using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для расчёта по формуле (в градусах)");
         double x = double.Parse(Console.ReadLine());

            double f = calculation(x);
            Console.WriteLine("Ответ равен " + f);

        }

        static double calculation(double x)
        {
            double xRad = x * Math.PI / 180;
            double tgX = Math.Tan(xRad);
            double sinX =Math.Sin(xRad);
            double cosX = Math.Cos(xRad);
            double chislitel = tgX + Math.Sqrt(sinX * sinX + 4);
            double znam = cosX * cosX + 4;
            return chislitel / znam;
        }
    }
}
