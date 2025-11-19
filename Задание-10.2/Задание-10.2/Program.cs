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
        {
            Console.WriteLine("Введите количество административных единиц: ");
            int unit = int.Parse(Console.ReadLine());

            int countryPopulation = 0;
            int countryArea = 0;

            for (int i = 1; i <= unit; i++)
            {
                Console.WriteLine("Административная единица номер " + i);
                Console.WriteLine("Введите количество жителей (в тыс. чел.): ");
                int population = int.Parse(Console.ReadLine());

                Console.WriteLine("  Введите площадь (кв. км.): ");
                int area = int.Parse(Console.ReadLine());

                countryPopulation += population;
                countryArea += area;
            }

            double density = countryPopulation * 1000 / countryArea;
            Console.WriteLine("Средняя плотность населения: " + density + " чел./кв. км.");
        }
    }
}
