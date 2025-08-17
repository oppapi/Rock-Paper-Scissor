using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor
{
    public partial class Form1 : Form
    {
        private string player;
        private string computer;
        private int playerScore = 0;
        private int computerScore = 0;
        public Form1()
        {
            InitializeComponent();
            displayScore();
        }

        private void displayScore()
        {
            txtPlayer.Text = "Player: " + playerScore.ToString();
            txtComputer.Text = "Computer: " + computerScore.ToString();
        }

        private void randomResponse()
        {
            Random random = new Random();
            int x = random.Next(1, 3);
            if (x == 0) { pictureBox1.Image =  global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1; computer = "rock"; }
            else if (x == 1) { pictureBox1.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER; computer = "paper"; }
            else { pictureBox1.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_; computer = "scissor"; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!limitScore())
            {
                pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1;//rock
                player = "rock";
                randomResponse();
                check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!limitScore())
            {
                pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER;//paper
                player = "paper";
                randomResponse();
                check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!limitScore())
            {
                pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_;//scissor
                player = "scissor";
                randomResponse();
                check();
            }
        }

        private bool limitScore()
        {
            if(playerScore == 5 || computerScore == 5)
            {
                MessageBox.Show("Game is Done!");
                computerScore = 0;
                playerScore = 0;
                displayScore();
                return true;
            }
            return false;
        }

        private void check()
        {
            if (player=="rock" && computer == "paper")
            {
                MessageBox.Show("Computer wins!");
                computerScore++;
            }
            else if (player == "rock" && computer == "scissor")
            {
                MessageBox.Show("Player wins!");
                playerScore++;
            }
            else if (player == "paper" && computer == "rock")
            {
                MessageBox.Show("Player wins!");
                playerScore++;
            }
            else if (player == "paper" && computer == "scissor")
            {
                MessageBox.Show("Computer wins!");
                computerScore++;
            }
            else if (player == "scissor" && computer == "rock")
            {
                MessageBox.Show("Computer wins!");
                computerScore++;
            }
            else if (player == "scissor" && computer == "paper")
            {
                MessageBox.Show("Player wins!");
                playerScore++;
            }
            else
            {
                MessageBox.Show("It's a tie!");
            }
            player = "";
            computer = "";
            displayScore();
        }
    }
}
