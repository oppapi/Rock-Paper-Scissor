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
        public Form1()
        {
            InitializeComponent();
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
            pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1;//rock
            player = "rock";
            randomResponse();
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER;//paper
            player = "paper";
            randomResponse();
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_;//scissor
            player = "scissor";
            randomResponse();
            check();
        }

        private void check()
        {
            if (pictureBox5.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1
                && pictureBox1.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER)
            {
                MessageBox.Show("Computer wins!");
            }
            else if (pictureBox5.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1
                     && pictureBox1.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_)
            {
            {
                MessageBox.Show("Player wins!");
            }
            else if (pictureBox5.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER
                     && pictureBox1.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1)
            {
                MessageBox.Show("Player wins!");
            }
            else if (pictureBox5.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER
                     && pictureBox1.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_)
            {
                MessageBox.Show("Computer wins!");
            }
            else if (pictureBox5.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_
                     && pictureBox1.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1)
            {
                MessageBox.Show("Computer wins!");
            }
            else if (pictureBox5.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_
                     && pictureBox1.Image == global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER)
            {
                MessageBox.Show("Player wins!");
            }
            else
            {
                
            }

        }
    }
}
