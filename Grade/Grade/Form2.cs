using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //ShowForward("ChiangRai");
            //ShowBackWard("BackWard");
            //ShowForWard2("ChiangRai");
            //ShowBackWard2("ChiangRai");
        }
        private static void ShowForward(string st)
        {
            for(int i = 0; i < st.Length; i++)
            {
                MessageBox.Show(st.Substring(i, 1));
            }
        }
        private static void ShowBackWard(string st)
        {
            for (int i = st.Length-1; i > 0; i--)
            {
                MessageBox.Show(st.Substring(1, i));
            }
        }
        private static void ShowForWard2(string st)
        {
            char[] st2 = st.ToCharArray();
            for (int i = 0; i < st2.Length; i++)
            {
                MessageBox.Show(st2[i] + "");
            }
        }
        private static void ShowBackWard2(string st)
        {
            char[] st2 = st.ToCharArray();
            for (int i = st2.Length; i > 0; i--)
            {
                MessageBox.Show(st2[i-1] + "");
            }
        }
    }
}
