using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalulate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var score = Convert.ToDouble(textBox1.Text);
            if (score >= 0 && score <= 100)
            {
                if (score >= 80)
                    You_Grade.Text = "A";
                else if (score >= 70)
                    You_Grade.Text = "B";
                else if (score >= 50)
                    You_Grade.Text = "C";
                else if (score >= 35)
                    You_Grade.Text = "D";
                else
                    You_Grade.Text = "F";
            }
            else
                this.You_Grade.ResetText(); 
        }

    }
}
