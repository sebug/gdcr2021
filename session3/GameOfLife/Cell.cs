using System;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLife
{
    public class Cell
    {

        private bool isAlive;

        public Cell(bool isAlive)
        {
            this.isAlive = isAlive;
        }

        private List<Cell> Neighbors { get; } = new List<Cell>();

        public int NeighborCount
        {
            get
            {
                return this.Neighbors.Count;
            }
        }

        public Cell AddNeighbor(Cell otherCell)
        {
            this.Neighbors.Add(otherCell);
            return this;
        }

        internal bool IsDead
        {
            get
            {
                return !isAlive;
            }
        }

        internal bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public int AliveNeighborCount
        {
            get
            {
                return this.Neighbors.Where(c => c.IsAlive).Count();
            }
        }
    }
}
