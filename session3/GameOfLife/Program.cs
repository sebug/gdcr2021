using System;
using System.Diagnostics;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ACellCanBeDead();
        }

        private static void ACellCanBeDead()
        {
            var cell = new Cell();
            Debug.Assert(cell.IsDead());
        }
    }
}
