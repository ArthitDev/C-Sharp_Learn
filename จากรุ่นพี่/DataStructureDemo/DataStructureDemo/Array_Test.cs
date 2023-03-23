using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureDemo
{
    public partial class Array_Test : Form
    {
        public Array_Test()
        {
            InitializeComponent();
        }

        private void Array_Test_Load(object sender, EventArgs e)
        {
            int[] data = { 2,6,5,4,8,6,4,8,7,4,5,6,3,2,1,5,1,5,6,3,5,4,8,5,4,7,8,5,1,5,2,3,6,5,4,5,8,5,5,6,3,2,1,2,5,1,4,7,8,5,1};
            for (int i = 0;i < data.Length;i++)
            {
                Console.WriteLine(data[i]);
            }

        }
    }
}
