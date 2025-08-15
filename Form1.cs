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
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_SCISSOR1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview_PAPER;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = global::Rock_Paper_Scissor.Properties.Resources.image_removebg_preview__9_;
        }
    }
}
