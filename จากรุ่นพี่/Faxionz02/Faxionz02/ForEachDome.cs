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
    public partial class ForEachDome : Form
    {
        public ForEachDome()
        {
            InitializeComponent();
        }

        private void ForEachDome_Load(object sender, EventArgs e)
        {
            int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            foreach(int num in Number)
            {
                Console.WriteLine(num);
            }
            String[] grade = { "A", "B+", "B", "C+", "C", "D+", "D", "F" };
            foreach(String st in grade)
            {
                Console.WriteLine(st);
            }
            //foreach(TextBox txt in this.Controls)
            //{
            //    txt.Text = "CRRU";
            //}
            foreach(Control control in this.Controls.OfType<TextBox>())
            {
                control.Text = "CRRU";
            }
        }
    }
}
