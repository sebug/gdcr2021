using System;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLife
{
    public class Cell
    {

        private bool isAlive;

        public Cell()
        {
            this.isAlive = true;
        }

        private List<Cell> Neighbors { get; } = new List<Cell>();

        public Cell AddNeighbor(Cell otherCell)
        {
            if (this == otherCell)
            {
                return this;
            }
            if (!this.Neighbors.Contains(otherCell))
            {
                this.Neighbors.Add(otherCell);
                otherCell.AddNeighbor(this);
            }
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
