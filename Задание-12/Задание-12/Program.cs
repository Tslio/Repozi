using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа m и n от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var strings = input.Split();

                if (strings.Length == 2 && int.TryParse(strings[0], out m) &&
                    int.TryParse(strings[1], out n) && 5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;
                else
                    Console.WriteLine("Ошибка ввода");
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine();

            PrintTable(matrix);
            Console.WriteLine();

            var rowIndex = GetRowWithMaxFirstElement(matrix);

            if (rowIndex >= 0)
                Console.WriteLine($"У строки с индексом {rowIndex} первый элемент наибольший");
            else
                Console.WriteLine("Нет строки с первым наибольшим элементом ");

            Console.WriteLine();
            var sums = GetSumOfSquares(matrix);

            for (int i = 0; i < sums.Length; i++)
                Console.WriteLine($"Строка {i}: сумма квадратов = {sums[i]}");
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],3} ");

                Console.WriteLine();
            }
        }
        static int GetRowWithMaxFirstElement(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                bool isMax = true;

                for (int j = 1; j < table.GetLength(1); j++)
                    if (table[i, j] > table[i, 0])
                    {
                        isMax = false;
                        break;
                    }

                if (isMax)
                    return i;
            }

            return -1;
        }
        
        static int[] GetSumOfSquares(int[,] table)
        
        {
            var result = new int[table.GetLength(0)];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < table.GetLength(1); j++)
                    sum += table[i, j] * table[i, j];

                result[i] = sum;
            }
            return result;
        }
    }
}
