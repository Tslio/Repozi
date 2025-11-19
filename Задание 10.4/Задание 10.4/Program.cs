using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            int minDigit = 9;    
            int minPosition = 1;
            int position = 1;    

            for (int numberForCalculation = number; numberForCalculation > 0; numberForCalculation /= 10, position++)
            {
                int digit = numberForCalculation % 10; 

                if (digit < minDigit)
                {
                    minDigit = digit;
                    minPosition = position;
                }
            }

            Console.WriteLine("Порядковый номер минимальной цифры справа налево: " + minPosition);
        }
    }
}
