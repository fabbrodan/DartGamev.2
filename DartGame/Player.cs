using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame
{
    class Player
    {
        private string Name;
        private List<Turn> Turns;
        private Turn currentTurn;
        private int Points;

        public Player(string Name)
        {
            this.Name = Name;
            this.Turns = new List<Turn>();
        }

        public override string ToString()
        {
            return this.Name;
        }

        public Turn GetCurrentTurn()
        {
            return currentTurn;
        }

        public void UpdateScore()
        {
           foreach (Throw _throw in currentTurn.GetThrows())
           {
                Points += _throw.GetPoint();
           }
        }

        public void AddTurn(int turnIndex)
        {
            Turns.Add(new Turn());
            this.currentTurn = Turns[turnIndex];
        }

        public int GetTurnPoint(int turnIndex)
        {
            int turnPoints = 0;

            for (int i = 0; i < 3; i++)
            {
                turnPoints += Turns[turnIndex].GetThrows()[i].GetPoint();
            }

            return turnPoints;
        }

        public int GetTotalPoints()
        {
            return this.Points;
        }
    }
}
