using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class ListTest : Form
    {

        List<int> number = new List<int>();


        public ListTest()
        {
            InitializeComponent();
        }

        private void ListTest_Load(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            number.Add(int.Parse(TextBox.Text));
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            foreach(int data in number)
            {
                Console.WriteLine(data + "");
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            //number.Remove(2);
            //number.RemoveAt(2);
            //number.RemoveRange(0,2);

        }

        private void bSearch1_Click(object sender, EventArgs e)
        {
            int index = number.IndexOf(7,2);
        }
    }
}
