using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание10._5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите пробег в первый день: ");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите процент увеличения пробега : ");
            int increase = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите желаемый суммарный пробег: ");
            int goal = int.Parse(Console.ReadLine());

            int sum = 0;
            int dayDistance = distance;
            int day = 0;

            while (sum <= goal)
            {
                day++;
                sum += dayDistance;
                dayDistance += dayDistance * (increase / 100);
            }

            Console.WriteLine("Суммарный пробег превысит указанную желаемую дистанцию на " + day + " день");
        }
    }
}
