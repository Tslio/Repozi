using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StartWord = "телега";
            Console.WriteLine(StartWord.Remove(0, 2)
                + StartWord.Remove(1, 5));
            Console.WriteLine(StartWord.Remove(0, 5)
                + StartWord.Remove(1, 5)
                + StartWord.Remove(4, 2).Remove(0, 2)
                + StartWord.Remove(1,5));
        }
    }
}
