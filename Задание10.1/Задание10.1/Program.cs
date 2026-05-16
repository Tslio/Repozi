using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание10._1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите действительное число x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            double result = CalculateSum(x, n);
            Console.WriteLine("Сумма равна: " + result);
        }
        static double CalculateSum(double x, int n)
        {
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                int value = 2*i+1;

                double term = Math.Pow(x, value) / value;
                sum += term;
            }

            return sum;
        }
    }
}