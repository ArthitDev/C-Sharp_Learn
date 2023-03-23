using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiramidTest
{
    public partial class Form1 : Form
    {
        int[] value = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, };
        int[] age = { 20, 21, 22, 25, 28, 25, 25, 20, 28, 35, 24, 20, 25, 27, 28, 29, 33, 75, 55, 45, 43, 33, 31, 29, 36, 75, 60, 62, 66, 30, };
        public Form1()
        {
            InitializeComponent();
            TestAgeValue();
        }
        private void TestAgeValue()
        {
            int[] Cvalue = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < age.Length; i++)
            {
                switch (value[i])
                {
                    case 1: Cvalue[0]++; break;
                    case 2: Cvalue[1]++; break;
                    case 3: Cvalue[2]++; break;
                    case 4: Cvalue[3]++; break;
                    case 5: Cvalue[4]++; break;
                }
            }
        }
    }
}
