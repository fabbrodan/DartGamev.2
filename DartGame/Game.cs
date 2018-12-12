using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DartGame
{
    class Game
    {
        private List<Player> PlayerList;
        private int TurnCount;
        private Player currentPlayer;
        private int Currentplayerindex;

        public Game()
        {
            this.PlayerList = new List<Player>();
            this.Currentplayerindex = 0;
            this.TurnCount = 0;
        }

        public void AddPlayer(Player player)
        {
            PlayerList.Add(player);
            LogWriter.Write(player.ToString() + " added to Players");
        }

        public List<Player> GetPlayerlist()
        {
            return this.PlayerList;
        }

        public bool CheckPlayerExists(Player player)
        {
            if (PlayerList.Count > 0)
            {
                if (PlayerList.Find(x => x.ToString() == player.ToString()) != null)
                {
                    LogWriter.Write(player.ToString() + " was not not able to be added since he/she already exists!");
                    return true;
                }
            }

            return false;
        }

        public void NextPlayer()
        {
            if (Currentplayerindex == PlayerList.Count  - 1)
            {
                Currentplayerindex = 0;
                this.TurnCount += 1;
            }
            else
            {
                Currentplayerindex += 1;
            }
            SetPlayer();
        }

        public void SetPlayer()
        {
            currentPlayer = PlayerList[Currentplayerindex];
            currentPlayer.AddTurn(TurnCount);
        }

        public Player GetCurrentPlayer()
        {
            return this.currentPlayer;
        }

        public int GetTurnCount()
        {
            return this.TurnCount;
        }

        public void NextTurn()
        {
            TurnCount += 1;
        }

        public bool CheckScore(Player player)
        {
            int score = player.GetTotalPoints();
            if (score == 301)
            {
                return true;
            }
            else if (score < 301)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
