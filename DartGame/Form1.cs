using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Remove before final build
using System.Diagnostics;

namespace DartGame
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            this.game = new Game();
            scoreboard.Visible = false;
            LogWriter.NewFile();
            LogWriter.Write("Program started!");
        }

        private void OnDartBoard_Click(object sender, EventArgs e)
        {
            MouseEventArgs mE = (MouseEventArgs)e;
            Player currentPlayer = game.GetCurrentPlayer();
            Turn currentTurn = currentPlayer.GetCurrentTurn();
            playerListBox.SelectedIndex = game.GetPlayerlist().IndexOf(currentPlayer);
            if (currentTurn.GetThrowCount() < 3)
            {
                currentTurn.AddThrow(new Throw(mE.Location.X, mE.Location.Y));
                LogWriter.Write(currentPlayer.ToString() + " threw " + currentTurn.GetThrows()[currentTurn.GetThrowCount() - 1].GetPoint());
                if (currentTurn.GetThrowCount() == 3)
                {
                    currentPlayer.UpdateScore();
                    UpdateScoreboard();
                    game.NextPlayer();
                    playerListBox.SelectedIndex = game.GetPlayerlist().IndexOf(game.GetCurrentPlayer());
                }
            }
        }

        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            DartBoard.DrawBoard(e, this.pictureBox1);
        }

        private void AddPlayer_ButtonClick(object sender, EventArgs e)
        {
            string name = playerName_tb.Text;
            Player player = new Player(name);
            if (!game.CheckPlayerExists(player))
            {
                game.AddPlayer(player);
                playerListBox.Items.Add(player);
            }
            else
            {
                MsgBox_Show.Show_Message(player.ToString() + " is already in the game!");
            }

            playerName_tb.Clear();
            playerName_tb.Focus();
        }

        private void UpdateScoreboard()
        {
            scoreboard.Items.Clear();
            foreach(Player player in playerListBox.Items)
            {
                scoreboard.Items.Add(player + " " + player.GetTotalPoints());
            }
        }

        private void StartGame_ButtonClick(object sender, EventArgs e)
        {
            pictureBox1.Click += new EventHandler(OnDartBoard_Click);
            LogWriter.Write("New game started.");
            MsgBox_Show.Show_Message("Game started!");
            playerListBox.Enabled = false;
            start_Btn.Enabled = false;
            playerName_tb.Enabled = false;
            playerAdd_btn.Enabled = false;
            scoreboard.Visible = true;
            UpdateScoreboard();
            game.SetPlayer();
        }
    }
}
