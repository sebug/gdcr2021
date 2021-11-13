using System;
using System.Linq;
using System.Collections.Generic;

namespace GameOfLife
{
    public class Cell
    {


        public Cell()
        {
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


        internal bool IsAlive
        {
            get
            {
                return true;
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
