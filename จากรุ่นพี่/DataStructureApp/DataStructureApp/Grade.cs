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
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            score.Focus();
        }

        private void score_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (int.Parse(score.Text) >= 80)
                        grade.Text = "A";
                    else
                        if (int.Parse(score.Text) >= 75)
                        grade.Text = "B+";
                    else
                        if (int.Parse(score.Text) >= 70)
                        grade.Text = "B";
                    else
                        if (int.Parse(score.Text) >= 60)
                        grade.Text = "C+";
                    else
                        if (int.Parse(score.Text) >= 50)
                        grade.Text = "C";
                    else
                        if (int.Parse(score.Text) >= 45)
                        grade.Text = "D+";
                    else
                        if (int.Parse(score.Text) >= 40)
                        grade.Text = "D";
                    else
                        grade.Text = "F";
                }
                catch(Exception)
                {
                    grade.Text = "";
                }
            }
        }
    }
}
