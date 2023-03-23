using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test001
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" เฟย์ ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("เฟย์");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(1);
            MessageBox.Show("เฟย์");
        }
    }
}
