using System;
using System.Diagnostics;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ACellCanBeDead();
            ACellCanBeAlive();
        }

        private static void ACellCanBeDead()
        {
            var cell = new Cell(false);
            Debug.Assert(cell.IsDead);
        }

        private static void ACellCanBeAlive()
        {
            var cell = new Cell(true);
            Debug.Assert(cell.IsAlive);
        }
    }
}
