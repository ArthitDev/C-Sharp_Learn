using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureApp
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

        private void score_TextChanged(object sender, EventArgs e)
        {

        }

        private void score_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (int.Parse(score.Text) >= 80)
                        grade.Text = "PD";
                    else
                        if (int.Parse(score.Text) >= 50)
                            grade.Text = "S";
                        else
                            grade.Text = "U";
                }
                catch (Exception)
                {
                    grade.Clear();
                }
            }
        }
    }
}
