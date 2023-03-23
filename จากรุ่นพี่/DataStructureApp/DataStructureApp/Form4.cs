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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void mount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String[] mlis = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int i = int.Parse(mount.Text);
                mountname.Text = mlis[i - 1];

                //switch(mount.Text)
                //{
                //    case "1": mountname.Text = "January"; break;
                //    case "2": mountname.Text = "February"; break;
                //    case "3": mountname.Text = "March"; break;
                //    case "4": mountname.Text = "April"; break;
                //    case "5": mountname.Text = "May"; break;
                //    case "6": mountname.Text = "June"; break;
                //    case "7": mountname.Text = "July"; break;
                //    case "8": mountname.Text = "August"; break;
                //    case "9": mountname.Text = "September"; break;
                //    case "10": mountname.Text = "October"; break;
                //    case "11": mountname.Text = "November"; break;
                //    case "12": mountname.Text = "December"; break;
                //    default: mountname.Clear();  break;
                //}
            }
        }
    }
}
