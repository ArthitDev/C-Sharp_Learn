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
    public partial class fullname : Form
    {
        public fullname()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void branch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                switch(branch.Text.ToLower())
                {
                    case "it": text2.Text = "Information Technology"; break;
                    case "cs": text2.Text = "Computer Science"; break;
                    case "bc": text2.Text = "Business Computer"; break;
                    case "gd": text2.Text = "Graphic Design"; break;
                    case "ce": text2.Text = "Computer Engineering"; break;
                    default : text2.Text = ""; break;
                }
            }
        }

        private void branch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
