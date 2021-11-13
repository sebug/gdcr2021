using System;
using System.Diagnostics;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ACellCanBeAlive();
            ACellCanHaveAliveNeighbors();
            NeighborsGoBothWays();
            NeighborsCountOnce();
            CantBeMyOwnNeighbor();
        }

        private static void ACellCanBeAlive()
        {
            var cell = new Cell();
            Debug.Assert(cell.IsAlive);
        }

        private static void ACellCanHaveAliveNeighbors()
        {
            var cell1 = new Cell();
            var cell2 = new Cell();

            cell1.AddNeighbor(cell2);

            Debug.Assert(cell1.AliveNeighborCount > 0);
        }

        private static void NeighborsGoBothWays()
        {
            var cell1 = new Cell();
            var cell2 = new Cell();

            cell1.AddNeighbor(cell2);

            Debug.Assert(cell2.AliveNeighborCount > 0);
        }

        private static void NeighborsCountOnce()
        {
            var cell1 = new Cell();
            var cell2 = new Cell();

            cell1.AddNeighbor(cell2);
            cell1.AddNeighbor(cell2);

            Debug.Assert(cell2.AliveNeighborCount == 1);
        }

        private static void CantBeMyOwnNeighbor()
        {
            var cell1 = new Cell();

            cell1.AddNeighbor(cell1);

            Debug.Assert(cell1.AliveNeighborCount == 0);
        }
    }
}
