using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырёхзначное число.");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000 || number > 9999)
                {
                Console.WriteLine("Введённое число не соответствует условию.");
                return;
            }

            int thousands = number/1000;
            int hundreds = (number/100)%10;
            int tens = (number/10)%10;
            int edinitsi = number%10;
            int sum = thousands + hundreds + tens + edinitsi;

            Console.WriteLine("Количество сотен: " + hundreds + "; количество десятков: " + tens);
            Console.WriteLine("Сумма цифр равна " + sum);
        }
    }
}
