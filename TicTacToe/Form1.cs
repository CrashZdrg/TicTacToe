using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {

        private bool IsYourTurn = true;
        private Button[,] Cells = new Button[3, 3]; // Buttons variable
        private bool[,] Empty = new bool[3, 3]; // Player 'X'
        private bool[,] Empty2 = new bool[3, 3]; // ALL
        private bool[,] Empty3 = new bool[3, 3]; // AI 'O'
        private bool ended = true;
        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        private Random rand = new Random();

        public TicTacToe()
        {
            InitializeComponent();

            // Designer buttons to an array variable
            Cells[0, 0] = A1BT;
            Cells[0, 1] = A2BT;
            Cells[0, 2] = A3BT;
            Cells[1, 0] = B1BT;
            Cells[1, 1] = B2BT;
            Cells[1, 2] = B3BT;
            Cells[2, 0] = C1BT;
            Cells[2, 1] = C2BT;
            Cells[2, 2] = C3BT;
        }

        // Write in console
        private void Cout(string s, int color = 0)
        {
            consoleLB.Items.Add(s);
            consoleLB.Items[consoleLB.Items.Count - 1].EnsureVisible();

            switch(color)
            {
                default: break;
                case 1:
                    consoleLB.Items[consoleLB.Items.Count - 1].ForeColor = Color.Red;
                    break;
                case 2:
                    consoleLB.Items[consoleLB.Items.Count - 1].ForeColor = Color.DarkGreen;
                    break;
                case 3:
                    consoleLB.Items[consoleLB.Items.Count - 1].ForeColor = Color.DarkBlue;
                    break;
            }
        }

        // Who win
        private void Winner(int i)
        {
            stopwatch.Reset();
            AIBrain(0);

            switch (i)
            {
                default: break;
                case 1:
                    Cout("Player Wins", 1);
                    break;
                case 2:
                    Cout("AI Wins", 1);
                    break;
                case 3:
                    Cout("Draw", 1);
                    break;
            }
            ended = true;
            rePlay.Enabled = true;
            rePlay.Text = "Play Again";
            comboBox1.Enabled = true;
        }

        // Check if there is a winner
        private void ThereIsWinner()
        {
            if (
                (A1BT.Text == "X" && A2BT.Text == "X" && A3BT.Text == "X") ||
                (B1BT.Text == "X" && B2BT.Text == "X" && B3BT.Text == "X") ||
                (C1BT.Text == "X" && C2BT.Text == "X" && C3BT.Text == "X") ||

                (A1BT.Text == "X" && B1BT.Text == "X" && C1BT.Text == "X") ||
                (A2BT.Text == "X" && B2BT.Text == "X" && C2BT.Text == "X") ||
                (A3BT.Text == "X" && B3BT.Text == "X" && C3BT.Text == "X") ||

                (A1BT.Text == "X" && B2BT.Text == "X" && C3BT.Text == "X") ||
                (A3BT.Text == "X" && B2BT.Text == "X" && C1BT.Text == "X")
                )
                Winner(1);
            else if (
                (A1BT.Text == "O" && A2BT.Text == "O" && A3BT.Text == "O") ||
                (B1BT.Text == "O" && B2BT.Text == "O" && B3BT.Text == "O") ||
                (C1BT.Text == "O" && C2BT.Text == "O" && C3BT.Text == "O") ||

                (A1BT.Text == "O" && B1BT.Text == "O" && C1BT.Text == "O") ||
                (A2BT.Text == "O" && B2BT.Text == "O" && C2BT.Text == "O") ||
                (A3BT.Text == "O" && B3BT.Text == "O" && C3BT.Text == "O") ||

                (A1BT.Text == "O" && B2BT.Text == "O" && C3BT.Text == "O") ||
                (A3BT.Text == "O" && B2BT.Text == "O" && C1BT.Text == "O")
                )
                Winner(2);
            else
            {
                int buffer = 0;
                for (int x = 0, y = 0; x < 3 || y < 3; x++)
                {
                    if (x == 3)
                    {
                        x = 0;
                        y++;
                        if (y == 3) break;
                    }
                    if (!Empty2[x, y])
                        break;
                    else buffer++;

                    if (buffer == 9) Winner(3);
                }
            }
        }

        // AI puts on a cell
        private void Put(int x, int y)
        {
            Empty2[x, y] = true;
            Empty3[x, y] = true;
            Cells[x, y].ForeColor = Color.Blue;
            Cells[x, y].Text = "O";

            Cout("AI Puts on [" + x.ToString() + ", " + y.ToString() + "]", 3);
        }

        // Player puts on a cell
        private void PlPut(int x, int y)
        {
            Empty[x, y] = true;
            Empty2[x, y] = true;
            
            Cout("Pl Puts on [" + x.ToString() + ", " + y.ToString() + "]", 2);
        }

        // Try to win
        private void WinAI(ref bool b)
        {
            // A1
            if (Empty3[0, 0] && Empty3[0, 1] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty3[0, 0] && Empty3[1, 0] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty3[0, 0] && Empty3[1, 1] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty3[0, 0] && Empty3[2, 0] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty3[0, 0] && Empty3[0, 2] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty3[0, 0] && Empty3[2, 2] && !Empty2[1, 1]) Put(1, 1);

            // B1
            else if (Empty3[1, 0] && Empty3[0, 0] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty3[1, 0] && Empty3[2, 0] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty3[1, 0] && Empty3[1, 1] && !Empty2[1, 2]) Put(1, 2);
            else if (Empty3[1, 0] && Empty3[1, 2] && !Empty2[1, 1]) Put(1, 1);

            // C1
            else if (Empty3[2, 0] && Empty3[1, 0] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty3[2, 0] && Empty3[2, 1] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty3[2, 0] && Empty3[1, 1] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty3[2, 0] && Empty3[0, 0] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty3[2, 0] && Empty3[2, 2] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty3[2, 0] && Empty3[0, 2] && !Empty2[1, 1]) Put(1, 1);

            // A2
            else if (Empty3[0, 1] && Empty3[0, 0] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty3[0, 1] && Empty3[0, 2] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty3[0, 1] && Empty3[1, 1] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty3[0, 1] && Empty3[2, 1] && !Empty2[1, 1]) Put(1, 1);

            // B2
            else if (Empty3[1, 1] && Empty3[0, 0] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty3[1, 1] && Empty3[0, 1] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty3[1, 1] && Empty3[0, 2] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty3[1, 1] && Empty3[1, 2] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty3[1, 1] && Empty3[2, 2] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty3[1, 1] && Empty3[2, 1] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty3[1, 1] && Empty3[2, 0] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty3[1, 1] && Empty3[1, 0] && !Empty2[1, 2]) Put(1, 2);

            // C2
            else if (Empty3[2, 1] && Empty3[2, 0] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty3[2, 1] && Empty3[2, 2] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty3[2, 1] && Empty3[1, 1] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty3[2, 1] && Empty3[0, 1] && !Empty2[1, 1]) Put(1, 1);

            // A3
            else if (Empty3[0, 2] && Empty3[0, 1] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty3[0, 2] && Empty3[1, 2] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty3[0, 2] && Empty3[1, 1] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty3[0, 2] && Empty3[0, 0] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty3[0, 2] && Empty3[2, 2] && !Empty2[1, 2]) Put(1, 2);
            else if (Empty3[0, 2] && Empty3[2, 0] && !Empty2[1, 1]) Put(1, 1);

            // B3
            else if (Empty3[1, 2] && Empty3[0, 2] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty3[1, 2] && Empty3[2, 2] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty3[1, 2] && Empty3[1, 1] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty3[1, 2] && Empty3[1, 0] && !Empty2[1, 1]) Put(1, 1);

            // C3
            else if (Empty3[2, 2] && Empty3[1, 2] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty3[2, 2] && Empty3[2, 1] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty3[2, 2] && Empty3[1, 1] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty3[2, 2] && Empty3[0, 2] && !Empty2[1, 2]) Put(1, 2);
            else if (Empty3[2, 2] && Empty3[2, 0] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty3[2, 2] && Empty3[0, 0] && !Empty2[1, 1]) Put(1, 1);

            else b = true;
        }

        // Try to not lose
        private void DrawAI(ref bool b)
        {
            // A1
            if (Empty[0, 0] && Empty[0, 1] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty[0, 0] && Empty[1, 0] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty[0, 0] && Empty[1, 1] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty[0, 0] && Empty[2, 0] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty[0, 0] && Empty[0, 2] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty[0, 0] && Empty[2, 2] && !Empty2[1, 1]) Put(1, 1);

            // B1
            else if (Empty[1, 0] && Empty[0, 0] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty[1, 0] && Empty[2, 0] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty[1, 0] && Empty[1, 1] && !Empty2[1, 2]) Put(1, 2);
            else if (Empty[1, 0] && Empty[1, 2] && !Empty2[1, 1]) Put(1, 1);

            // C1
            else if (Empty[2, 0] && Empty[1, 0] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty[2, 0] && Empty[2, 1] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty[2, 0] && Empty[1, 1] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty[2, 0] && Empty[0, 0] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty[2, 0] && Empty[2, 2] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty[2, 0] && Empty[0, 2] && !Empty2[1, 1]) Put(1, 1);

            // A2
            else if (Empty[0, 1] && Empty[0, 0] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty[0, 1] && Empty[0, 2] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty[0, 1] && Empty[1, 1] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty[0, 1] && Empty[2, 1] && !Empty2[1, 1]) Put(1, 1);

            // B2
            else if (Empty[1, 1] && Empty[0, 0] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty[1, 1] && Empty[0, 1] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty[1, 1] && Empty[0, 2] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty[1, 1] && Empty[1, 2] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty[1, 1] && Empty[2, 2] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty[1, 1] && Empty[2, 1] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty[1, 1] && Empty[2, 0] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty[1, 1] && Empty[1, 0] && !Empty2[1, 2]) Put(1, 2);

            // C2
            else if (Empty[2, 1] && Empty[2, 0] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty[2, 1] && Empty[2, 2] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty[2, 1] && Empty[1, 1] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty[2, 1] && Empty[0, 1] && !Empty2[1, 1]) Put(1, 1);

            // A3
            else if (Empty[0, 2] && Empty[0, 1] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty[0, 2] && Empty[1, 2] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty[0, 2] && Empty[1, 1] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty[0, 2] && Empty[0, 0] && !Empty2[0, 1]) Put(0, 1);
            else if (Empty[0, 2] && Empty[2, 2] && !Empty2[1, 2]) Put(1, 2);
            else if (Empty[0, 2] && Empty[2, 0] && !Empty2[1, 1]) Put(1, 1);

            // B3
            else if (Empty[1, 2] && Empty[0, 2] && !Empty2[2, 2]) Put(2, 2);
            else if (Empty[1, 2] && Empty[2, 2] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty[1, 2] && Empty[1, 1] && !Empty2[1, 0]) Put(1, 0);
            else if (Empty[1, 2] && Empty[1, 0] && !Empty2[1, 1]) Put(1, 1);

            // C3
            else if (Empty[2, 2] && Empty[1, 2] && !Empty2[0, 2]) Put(0, 2);
            else if (Empty[2, 2] && Empty[2, 1] && !Empty2[2, 0]) Put(2, 0);
            else if (Empty[2, 2] && Empty[1, 1] && !Empty2[0, 0]) Put(0, 0);
            else if (Empty[2, 2] && Empty[0, 2] && !Empty2[1, 2]) Put(1, 2);
            else if (Empty[2, 2] && Empty[2, 0] && !Empty2[2, 1]) Put(2, 1);
            else if (Empty[2, 2] && Empty[0, 0] && !Empty2[1, 1]) Put(1, 1);

            else b = true;
        }

        // Do whatever
        private int rx = 0, ry = 0;
        private void OtherAI()
        {

            /*if (!Empty[0, 0] && !Empty2[0, 0]) Put(0, 0);
            else if (!Empty[0, 1] && !Empty2[0, 1]) Put(0, 1);
            else if (!Empty[0, 2] && !Empty2[0, 2]) Put(0, 2);
            else if (!Empty[1, 0] && !Empty2[1, 0]) Put(1, 0);
            else if (!Empty[1, 1] && !Empty2[1, 1]) Put(1, 1);
            else if (!Empty[1, 2] && !Empty2[1, 2]) Put(1, 2);
            else if (!Empty[2, 0] && !Empty2[2, 0]) Put(2, 0);
            else if (!Empty[2, 1] && !Empty2[2, 1]) Put(2, 1);
            else if (!Empty[2, 2] && !Empty2[2, 2]) Put(2, 2);*/

            rx = rand.Next(3);
            ry = rand.Next(3);

            if (!Empty[rx, ry] && !Empty2[rx, ry])
                Put(rx, ry);
            else OtherAI();
        }

        // AI thinking
        private void AI()
        {
            if (!ended)
            {
                stopwatch.Start();

                bool b = false;

                AIBrain(1);
                WinAI(ref b);
                if (b)
                {

                    AIBrain(2);
                    b = false;
                    DrawAI(ref b);
                }
                if (b)
                {
                    AIBrain(3);
                    OtherAI();
                }

                stopwatch.Stop();
                Cout("AI Time: " + stopwatch.Elapsed.TotalMilliseconds.ToString("00.00000") + " ms", 3);
                stopwatch.Restart();
                ThereIsWinner();
                IsYourTurn = true;
            }
        }

        // What AI is doing
        private void AIBrain(int i)
        {
            switch(i)
            {
                case 0:
                    AIBrainLB.Text = "AI is waiting";
                    AIBrainLB.ForeColor = SystemColors.ControlText;
                    break;
                case 1:
                    AIBrainLB.Text = "AI tried to win";
                    AIBrainLB.ForeColor = Color.Red;
                    break;
                case 2:
                    AIBrainLB.Text = "AI tried to not lose";
                    AIBrainLB.ForeColor = Color.Blue;
                    break;
                case 3:
                    AIBrainLB.Text = "AI is not trying anything";
                    AIBrainLB.ForeColor = Color.Green;
                    break;
            }
        }

        // Clicked on a cell
        private void Cell_Click(object sender, EventArgs e)
        {
            if (!ended)
            {
                Button BT = sender as Button;
                if (IsYourTurn && BT.Text == "")
                {
                    if (BT == A1BT) PlPut(0, 0);
                    else if (BT == A2BT) PlPut(0, 1);
                    else if (BT == A3BT) PlPut(0, 2);
                    else if (BT == B1BT) PlPut(1, 0);
                    else if (BT == B2BT) PlPut(1, 1);
                    else if (BT == B3BT) PlPut(1, 2);
                    else if (BT == C1BT) PlPut(2, 0);
                    else if (BT == C2BT) PlPut(2, 1);
                    else if (BT == C3BT) PlPut(2, 2);

                    BT.ForeColor = Color.Red;
                    BT.Text = "X";
                    IsYourTurn = false;

                    stopwatch.Stop();
                    Cout("Pl Time: " + stopwatch.Elapsed.TotalSeconds.ToString("00.00000") + " s", 2);
                    stopwatch.Restart();

                    ThereIsWinner();

                    AI();
                }
            }
        }

        // Play button
        private void rePlay_Click(object sender, EventArgs e)
        {
            if (ended)
            {
                rePlay.Enabled = false;
                comboBox1.Enabled = false;

                for (int x = 0, y = 0; x < 3 || y < 3; x++)
                {
                    if (x == 3)
                    {
                        x = 0;
                        y++;
                        if (y == 3) break;
                    }
                    Cells[x, y].ForeColor = SystemColors.ControlText;
                    Cells[x, y].Text = "";
                    Empty[x, y] = false;
                    Empty2[x, y] = false;
                    Empty3[x, y] = false;
                }

                if (comboBox1.SelectedIndex == 0)
                {
                    ended = false;
                    IsYourTurn = true;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    ended = false;
                    IsYourTurn = false;
                    AI();
                }
                stopwatch.Start();
            }
        }
    }
}
