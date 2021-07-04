using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            lblPlayerTurn.Text = rand.Next(1, 2).ToString();

        }
        string[,] playerMap = new string[3, 3];
        Image iconOfPlayerOne = Image.FromFile("..\\..\\src\\x.png");
        Image iconOfPlayerTwo = Image.FromFile("..\\..\\src\\o.png");
        int playerOneScore = 0, playerTwoScore = 0;
        private void btnResetScore_Click(object sender, EventArgs e)
        {
            playerOneScore = playerTwoScore = 0;
            lblScore.Text = "0-0";
            ResetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid1_Click(object sender, EventArgs e)
        {
            gridAction(grid1, 0, 0);
        }

        private void grid2_Click(object sender, EventArgs e)
        {
            gridAction(grid2, 1, 0);

        }

        private void grid3_Click(object sender, EventArgs e)
        {
            gridAction(grid3, 2, 0);
        }

        private void grid4_Click(object sender, EventArgs e)
        {
            gridAction(grid4, 0, 1);
        }

        private void grid5_Click(object sender, EventArgs e)
        {
            gridAction(grid5, 1, 1);
        }

        private void grid6_Click(object sender, EventArgs e)
        {
            gridAction(grid6, 2, 1);
        }

        private void grid7_Click(object sender, EventArgs e)
        {
            gridAction(grid7, 0, 2);
        }

        private void grid8_Click(object sender, EventArgs e)
        {
            gridAction(grid8, 1, 2);
        }

        private void grid9_Click(object sender, EventArgs e)
        {
            gridAction(grid9, 2, 2);
        }
        private void SwitchTurns()
        {
            switch (lblPlayerTurn.Text)
            {
                case "1":
                    lblPlayerTurn.Text = "2";
                    break;
                case "2":
                    lblPlayerTurn.Text = "1";
                    break;
                default:
                    Console.WriteLine("Wtf");
                    break;
            }
        }
        private bool IsPlayerOneTurn()
        {
            return lblPlayerTurn.Text == "1";
        }
        private bool CheckIfThePlayerHasWon(int x, int y, string[,] playerMap, string playerCharacter)
        {
            string temp = "", temp2 = "";
            string winCondition = playerCharacter + playerCharacter + playerCharacter;
            if (x + y == 0 || x + y == 2 || x + y == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    temp += playerMap[i, i];
                }
                for (int i = 0, k = 2; k >= 0; i++, k--)
                {
                    temp2 += playerMap[i, k];
                }
                if (temp == winCondition || temp2 == winCondition) return true;
            }
            temp = temp2 = "";
            for (int i = 0; i < 3; i++)
            {
                temp += playerMap[x, i];
                temp2 += playerMap[i, y];
            }
            if (temp == winCondition || temp2 == winCondition) return true;
            return false;
        }
        private void ThePlayerHasWon(int playerId)
        {
            string score = lblScore.Text;
            switch (playerId)
            {
                case 1:
                    lblGreeting.Text = "Congrats to Player One ,\n He Won!";
                    mainPanel.Enabled = false;
                    break;
                default:
                    lblGreeting.Text = "Congrats to Player Two ,\n He Won!";
                    mainPanel.Enabled = false;
                    break;
            }
            wait(3000);
            ResetGame();

        }
        private void gridAction(Panel currentGrid, int x, int y)
        {


            if (IsPlayerOneTurn())
            {
                playerMap[x, y] = "X";
                currentGrid.BackgroundImage = iconOfPlayerOne;
                currentGrid.Enabled = false;
                if (CheckIfThePlayerHasWon(x, y, playerMap, "X"))
                {
                    updateScore(playerOneScore++, playerTwoScore);
                    ThePlayerHasWon(1);
                    
                }
                SwitchTurns();
            }
            else
            {
                playerMap[x, y] = "O";
                currentGrid.BackgroundImage = iconOfPlayerTwo;
                currentGrid.Enabled = false;
                if (CheckIfThePlayerHasWon(x, y, playerMap, "O"))
                {
                    updateScore(playerOneScore, playerTwoScore++);
                    ThePlayerHasWon(2);
                    
                }
                SwitchTurns();
            }

        }
        private bool GameCanStillBePlayed()
        {
            return grid1.Enabled || grid2.Enabled || grid3.Enabled ||
                grid4.Enabled || grid5.Enabled || grid6.Enabled ||
                grid7.Enabled || grid8.Enabled || grid9.Enabled;
        }
        private async void Draw()
        {
            lblGreeting.ForeColor = Color.Red;
            lblGreeting.Text = "Draw!";
            wait(3000);
            ResetGame();

        }
        private void ResetGame()
        {
            grid1.BackgroundImage = null;
            grid2.BackgroundImage = null;
            grid3.BackgroundImage = null;
            grid4.BackgroundImage = null;
            grid5.BackgroundImage = null;
            grid6.BackgroundImage = null;
            grid7.BackgroundImage = null;
            grid8.BackgroundImage = null;
            grid9.BackgroundImage = null;
            mainPanel.Enabled = true;
            grid1.Enabled = true;
            grid2.Enabled = true;
            grid3.Enabled = true;
            grid4.Enabled = true;
            grid5.Enabled = true;
            grid6.Enabled = true;
            grid7.Enabled = true;
            grid8.Enabled = true;
            grid9.Enabled = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    playerMap[i, j] = "";
                }
            }
            lblGreeting.Text = "";
            updateScore(playerOneScore, playerTwoScore);
        }

        private void updateScore(int playerOneScore, int playerTwoScore)
        {
            lblScore.Text = playerOneScore + "-" + playerTwoScore;
        }

        private void mainPanel_MouseHover(object sender, EventArgs e)
        {
            if (!GameCanStillBePlayed()) Draw();
        }

        private void wait(int mili)
        {
            Timer timer = new Timer();
            if (mili == 0 || mili < 0) return;
            timer.Interval = mili;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };
            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }
    }

}
