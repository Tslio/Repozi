using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._2
{
    internal class Program
    {
        static void Main()
        { Console.WriteLine("Введите количество административных единиц p: ");
            int p = int.Parse(Console.ReadLine());

            int totalPopulation = 0;
            int totalArea = 0;

            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine("  Введите количество жителей (в тыс. чел.): ");
                Console.WriteLine("  Введите количество жителей (в тыс. чел.): ");
                int population = int.Parse(Console.ReadLine());

                Console.WriteLine("  Введите площадь (км²): ");
                int area = int.Parse(Console.ReadLine());

                totalPopulation += population;
                totalArea += area;
            }

            double density = totalPopulation * 1000 / totalArea;

            Console.WriteLine("Средняя плотность населения: ", density, "чел./км²");
        }
    }
}
