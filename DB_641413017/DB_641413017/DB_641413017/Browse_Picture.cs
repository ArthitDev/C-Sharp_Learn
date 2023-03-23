using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_641413017
{
    public partial class Browse_Picture : Form
    {
        public Browse_Picture()
        {
            InitializeComponent();
        }

        private void Browse_Click_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = ("C:\\Users\\ArthitPC\\Pictures\\meme");
            openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|JFIF|*.jfif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
