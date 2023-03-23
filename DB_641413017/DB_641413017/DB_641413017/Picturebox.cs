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
    public partial class Picturebox : Form
    {
        string[] filename = { "meme_0.jpg", "meme_1.png", "meme_2.jfif", "meme_3.jpg", "meme_4.jpg" };
        int count = 0;
        public Picturebox()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            if(count < 4)
            {
                count++;
                pictureBox1.Image = Image.FromFile("C:\\Users\\ArthitPC\\Pictures\\meme\\" + filename[count]);
            }
            else
            {
                count = 0;
                pictureBox1.Image = Image.FromFile("C:\\Users\\ArthitPC\\Pictures\\meme\\" + filename[count]);
            }
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                pictureBox1.Image = Image.FromFile("C:\\Users\\ArthitPC\\Pictures\\meme\\" + filename[count]);
            }
            else
            {
                count = 4;
                pictureBox1.Image = Image.FromFile("C:\\Users\\ArthitPC\\Pictures\\meme\\" + filename[count]);
            }
        }
    }
}
