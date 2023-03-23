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
    public partial class StringTest : Form
    {
        public StringTest()
        {
            InitializeComponent();
        }

        private void StringTest_Load(object sender, EventArgs e)
        {

        }

        private void st_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                len.Text = st.Text.Length.ToString();
                first.Text = st.Text.Substring(0,1);
                last.Text = st.Text.Substring(st.Text.Length - 1);
                
                
            }
        }

        private void at_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ms = int.Parse(at.Text);
                len.Text = st.Text.Length + "";
                isChar.Text = st.Text.Substring(ms -1 , 1);
            }
        }

        private void from_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                to.Focus();
            }
        }

        private void to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int f = int.Parse(from.Text);
                int l = int.Parse(to.Text);
                int m = l - f + 1;
                isString.Text = st.Text.Substring(f - 1, m);
            }
        }

        private void to_TextChanged(object sender, EventArgs e)
        {
            tag.Focus();
        }

        private void tag_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.End)
            {
                int index = st.Text.IndexOf(tag.Text);
                if(index >=-1)
                {
                 //   //found.Text = "มี";
                 //   //found.index = index +;
                 //else
                 //   found.Text = "ไม่มี";
                }
            }
        }
    }
}
