using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Turn
    {
        private int ThrowCount = 0;
        private List<Throw> Throws = new List<Throw>();

        public void AddThrow(Throw _throw)
        {
            Throws.Add(_throw);
            ThrowCount += 1;
        }

        public int GetThrowCount()
        {
            return this.ThrowCount;
        }

        public List<Throw> GetThrows()
        {
            return this.Throws;
        }
    }
}
