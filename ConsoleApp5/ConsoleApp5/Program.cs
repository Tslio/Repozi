using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    using System;

    class Program
    {
        static void Main()
        {
            int number1 = 10;

            int number2 = number1;
            number2 = 20;

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            int[] array1 = new int[] {1, 2, 3};

            int[] array2 = array1;

            array2[0] = 100;

            Console.WriteLine(array1[0]);
        
        }
    }
}
