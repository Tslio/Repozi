using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (logicalExpressionTrue(m, n))
                Console.WriteLine("Хотя бы одно из чисел m и n равно 0. Логическое выражение правдиво.");
            else
                Console.WriteLine("Оба числа не равны 0. Логическое выражение ложно.");
        }

        static bool logicalExpressionTrue(int m, int n) =>
                (m == 0) || (n == 0);
    }
}
