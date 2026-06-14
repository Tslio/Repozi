using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива");

            var n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Слишком маленький массив.");
                return;
            }

            var numbers = new int[n];

            numbers[0] = 1;

            for (int k = 1; k < numbers.Length; k++)
                numbers[k] = numbers[k - 1] + (k + 1);

            PrintIntArray(numbers);

            DivideEvenElements(numbers);
            PrintIntArray(numbers);

            var evenCount = CountEven(numbers);
            Console.WriteLine("Количетво чётных элементов: " + evenCount);

            var partialSums = GetPartialSums(numbers);
            PrintIntArray(partialSums);
        }
        static void PrintIntArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item}, ");

            Console.WriteLine("\b\b.\n");
        }
        static void DivideEvenElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    array[i] /= 2;
        }
        static int CountEven(int[] array)

        {
            int counter = 0;

            foreach (var item in array)
                if (item % 2 == 0)
                    counter++;

            return counter;
        }
        static int[] GetPartialSums(int[] array)
        {
            var result = new int[array.Length];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                result[i] = sum;
            }
            return result;
        }
    }
}
