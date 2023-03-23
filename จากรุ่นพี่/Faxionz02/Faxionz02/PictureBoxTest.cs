using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faxionz02
{
    public partial class PictureBoxTest : Form
    {
        int sw = 1;
        public PictureBoxTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picture();
        }
        public void picture()
        {
            if (sw >= 1 && sw<= 5)
            {
                switch(sw)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.GH001;
                        prev.Enabled = false;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.GH002;
                        prev.Enabled = true;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.GH003;
                        prev.Enabled = true;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.GH004;
                        next.Enabled = true;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.GH005;
                        next.Enabled = false;
                        break;
                }
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            sw--;
            picture();
        }

        private void next_Click(object sender, EventArgs e)
        {
            sw++;
            picture();
        }
    }
}
