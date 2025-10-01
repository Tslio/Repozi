using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args  )
        {Console.WriteLine("Введите длину первого катета");
            var a = double.Parse(Console.ReadLine());

         Console.WriteLine("Введите длину второго катета");
            var b = double.Parse(Console.ReadLine());

            var hyp = Math.Sqrt(a * a + b * b);

            var med1 = hyp / 2; 
            var med2 = Math.Sqrt(2 * (b * b + hyp * hyp ) - a * a) / 2;
            var med3 = Math.Sqrt(2 * ( a * a + hyp * hyp ) - b * b) / 2;
            Console.WriteLine("Длины медиан равны: " + med1 + "; " + med2 + "; " + med3);
        }
    }
}
