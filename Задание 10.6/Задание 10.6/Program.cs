using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 10000; number++)
            {
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == number)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
