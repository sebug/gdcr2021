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
            ACellCanHaveAliveNeighbors();
            NeighborsGoBothWays();
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

        private static void ACellCanHaveAliveNeighbors()
        {
            var cell1 = new Cell(true);
            var cell2 = new Cell(true);

            cell1.AddNeighbor(cell2);

            Debug.Assert(cell1.AliveNeighborCount > 0);
        }

        private static void NeighborsGoBothWays()
        {
            var cell1 = new Cell(true);
            var cell2 = new Cell(true);

            cell1.AddNeighbor(cell2);

            Debug.Assert(cell2.AliveNeighborCount > 0);
        }
    }
}
