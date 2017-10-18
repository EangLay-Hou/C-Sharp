using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        //private void buttonClick(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    if (player % 2 == 0)
        //    {
        //        button.Text = "X";
        //        player++;
        //        turns++;
        //    }
        //    else
        //    {
        //        button.Text = "O";
        //        player++;
        //        turns++;
        //    }
        //    if (CheckDraw() == true)
        //    {
        //        MessageBox.Show("Tie Game!");
        //    }
        //    if (CheckWinner() == true)
        //    {
        //        if (button.Text == "X")
        //        {
        //            MessageBox.Show("X Won!");
        //            s1++;
        //            NewGame();
        //        }
        //        else
        //        {
        //            MessageBox.Show("O won!");
        //            s2++;
        //            NewGame();
        //        }
        //    }
        //}

        bool CheckWinner()
        {
            // horizoontal checks 
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;

            // Vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;

            // Diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != ""))
                return true;
            else
                return false;
        }

        bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { A00, A01, A02, A10, A11, A12, A20, A21, A22 };
            foreach (Button button in buttons)
                button.Click += Button_Click;
        }

        bool isClick = true;


        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text != "")
            {
                isClick = false;
            }
            else
            {
                isClick = true;
            }

            if (isClick == true)
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                isClick = false;
            }

            if (CheckDraw() == true)
            {
                MessageBox.Show("Tie Game!");
                sd++;
                NewGame();
            }
            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                }
                else
                {
                    MessageBox.Show("O won!");
                    s2++;
                    NewGame();
                }
            }
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draw: " + sd;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
        }

        // Button New Game
        private void NGButton_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        // Button Exit
        private void EButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
