using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Throw
    {
        private int Point;

        public Throw(int X, int Y)
        {
            this.Point = DartBoard.Throw(X, Y);
        }

        public int GetPoint()
        {
            return this.Point;
        }
    }
}
