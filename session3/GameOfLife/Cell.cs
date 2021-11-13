using System;
namespace GameOfLife
{
    public class Cell
    {

        private bool isAlive;

        public Cell(bool isAlive)
        {
            this.isAlive = isAlive;
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
