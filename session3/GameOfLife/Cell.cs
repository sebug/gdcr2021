using System;
namespace GameOfLife
{
    public class Cell
    {
        private bool isAlive = false;
        internal bool IsDead()
        {
            return !isAlive;
        }
    }
}
