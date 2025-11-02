using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8._3
{
    internal class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Введите позицию белого короля");
            var whiteKingPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию чёрного слона");
            var blackBishopPosition = Console.ReadLine();

            DecodePosition(whiteKingPosition, out int kingV, out int kingH);
            DecodePosition(blackBishopPosition, out int bishopV, out int bishopH);

            if (whiteKingPosition == blackBishopPosition)
            {
                Console.WriteLine("Фигуры не могут стоять на одной клетке.");
                return;
            }

            if ((bishopV + bishopH) % 2 == 1)
            {
                Console.WriteLine("Чёрный слон должен стоять на чёрной клетке.");
                return; 
            }

            if (IsUnderStrikeByKing(kingV, kingH, bishopV, bishopH))
                Console.WriteLine("Чёрный слон под боем белого короля.");
            else if (IsUnderStrikeByBishop(bishopV, bishopH, kingV, kingH))
                Console.WriteLine("Белый король под боем чёрного слона.");
            else
                Console.WriteLine("Ни одна фигура не находится под боем.");
        }

        static void DecodePosition(string position, out int vert, out int hor)
        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());
        }

        static bool IsUnderStrikeByKing(int kingV, int kingH, int bishopV, int bishopH)
        {
            return Math.Abs(kingV - bishopV) <= 1 && Math.Abs(kingH - bishopH) <= 1;
        }

        static bool IsUnderStrikeByBishop(int bishopV, int bishopH, int kingV, int kingH)
        {
            return Math.Abs(bishopV - kingV) == Math.Abs(bishopH - kingH);
        }
    }
}
