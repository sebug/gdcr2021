using System;
namespace GameOfLife
{
    public class Cell
    {
        public Cell(bool isAlive)
        {
            this.isAlive = isAlive;
        }

        private bool isAlive = false;
        internal bool IsDead()
        {
            return !isAlive;
        }

        internal bool IsAlive()
        {
            return isAlive;
        }
    }
}
