using System;
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

        public List<Cell> Neighbors { get; } = new List<Cell>();

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
    }
}
