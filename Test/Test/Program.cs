using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 1_000_000; i++)
            {
                if (IsHarshad(i))
                    count++;
            }

            Console.WriteLine(count);
        }
        static bool IsHarshad(int number)
        {
            int sumOfDigits = 0;
            int digit = number;

            while (digit > 0)
            {
                sumOfDigits += digit % 10;
                digit /= 10;
            }

            return number % sumOfDigits == 0;
        }
    }
}
