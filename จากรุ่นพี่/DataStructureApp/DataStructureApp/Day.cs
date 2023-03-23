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
    public partial class Day : Form
    {
        public Day()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void day_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string[] daylis = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday",};
                try
                {
                    int i = int.Parse(day.Text);
                    dayname.Text = daylis[i - 1];
                }
                catch(Exception)
                {
                    dayname.Text = " ใส่ตัวเลข 1-7 ";
                }
                //switch(day.Text)
                //{
                //    case "1" : dayname.Text = "Sunday"; break;
                //    case "2": dayname.Text = "Monday"; break;
                //    case "3": dayname.Text = "Tuesday"; break;
                //    case "4": dayname.Text = "Wednesday"; break;
                //    case "5": dayname.Text = "Thursday"; break;
                //    case "6": dayname.Text = "Friday"; break;
                //    case "7": dayname.Text = "Saturday"; break;
                //    default : dayname.Text = "ใส่เลข 1-7 " ; break;
                //}
                //if (day.Text == "1")
                //    dayname.Text = "Sunday";
                //else
                //    if (day.Text == "2")
                //    dayname.Text = "Monday";
                //else
                //    if (day.Text == "3")
                //    dayname.Text = "Tuesday";
                //else
                //    if (day.Text == "4")
                //    dayname.Text = "Wednesday";
                //else
                //    if (day.Text == "5")
                //    dayname.Text = "Thursday";
                //else
                //    if (day.Text == "6")
                //    dayname.Text = "Friday";
                //else
                //    if (day.Text == "7")
                //    dayname.Text = "Saturday";
                //else
                //    dayname.Text = "";
            }
        }
    }
}
