using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labirynt
{
    internal class Board
    {
        private char[,] map;
        public char[,] Map
        {
            get { return map; }
            set { }
        }

        public Board()
        {
            int x, y;

            Console.Clear();
            Console.WriteLine("------Labirynt------");
            for (; ; )
            {
                Console.Write("Podaj liczbe wierszy (0...100):");
                try { x = Convert.ToInt32(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("Podano nieprawidłową wartość...");
                    continue;
                }
                if (x <= 0 || x > 100)
                {
                    Console.WriteLine("Podano nieprawidłową wartość...");
                    continue;
                }
                break;
            }

            for (; ; )
            {
                Console.Write("Podaj liczbe kolumn (0...100):");
                try { y = Convert.ToInt32(Console.ReadLine()); }
                catch
                {
                    Console.Write("Podano nieprawidłową wartość...");
                    continue;
                }
                if (y <= 0 || y > 100)
                {
                    Console.Write("Podano nieprawidłową wartość...");
                    continue;
                }
                break;
            }

            Generate(x, y);
        }

        private void Generate(int x, int y)
        {
            map = new char[x + 2, y + 2]; // dodatkowe dwa pola na sciany

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if ((j == 0 || j == map.GetLength(0) - 1) && (i == 0 || i == map.GetLength(1) - 1))
                        map[i, j] = '+';
                    else if (j == 0 || j == map.GetLength(1) - 1)
                        map[i, j] = '|';
                    else if (i == 0 || i == map.GetLength(0) - 1)
                        map[i, j] = '-';
                    else
                        map[i, j] = 'o';
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
