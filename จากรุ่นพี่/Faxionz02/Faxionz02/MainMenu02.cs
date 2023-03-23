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
    public partial class MainMenu02 : Form
    {
        public MainMenu02()
        {
            InitializeComponent();
        }

        private void arrayTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new ArrayTest();
            fr.Show();
        }

        private void evaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Evaluation();
            fr.Show();
        }

        private void finaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Finance();
            fr.Show();
        }

        private void stringTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new StringTest();
            fr.Show();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new PictureBox();
            fr.Show();
        }

        private void ผสรางToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new About();
            fr.Show();
        }
    }
}
