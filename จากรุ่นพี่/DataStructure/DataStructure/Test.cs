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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            int[] data = new int[] { 10, 15, 45, 8,5};
            int key = 5;
            for(int i=0; i< data.Length; i++)
            {
                if (i == data[i]) ;
                {
                    if (key == data[i])
                    {
                        Console.WriteLine("found");
                        break;
                    }
                    Console.WriteLine("not found");
                    break;
                }
            }
        }
    }
}
