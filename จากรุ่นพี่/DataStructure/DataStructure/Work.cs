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
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();
        }

        private void Work_Load(object sender, EventArgs e)
        {

        }

        private void st_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_st.Text = st.Text.Length + "";
                f_st.Text = st.Text.Substring(0,1);
                l_st.Text = st.Text.Substring(28, 1);
                at_one.Focus();
            }
        }

        private void at_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    st_is.Text = st.Text.Substring(int.Parse(at_one.Text) - 1, 1);
                    st_ott.Text = st.Text.Substring(0, 3);
                    st_ff.Text = st.Text.Substring(3, 2);
                    at_two.Focus();
                }
            }catch(Exception)
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");
                at_one.Focus();
            }
        }

        private void at_two_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                at_to.Focus();
            }
        }

        private void at_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    isString.Text = st.Text.Substring(int.Parse(at_two.Text) - 1, int.Parse(at_to.Text) - (int.Parse(at_two.Text) - 1));
                    st_low.Focus();
                }catch(Exception)
                {
                    MessageBox.Show("Index out of range");
                }
            }    
        }

        private void st_low_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                c_y.Focus();
            }
        }
        private void ins_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                f_index.Focus();
            }
        }

        private void f_index_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && ins.TextLength > 0 && int.Parse(f_index.Text)-1 >=-1)
            {
                st.Text = st.Text.Insert(int.Parse(f_index.Text) - 1, ins.Text);
                replace.Focus();
            }
        }

        private void replace_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                with.Focus();
            }    
        }

        private void with_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && replace.TextLength > 0)
            {
                st.Text = st.Text.Replace(replace.Text, with.Text);
            }
        }

        private void c_y_CheckedChanged(object sender, EventArgs e)
        {
            if(c_y.Checked)
            {
                st_index.Text = (st.Text.IndexOf(st_low.Text, 0) + 1) + "";
                if (st_index.Text != "0")
                {
                    cn_show.Text = "มี";
                }
                else
                {
                    cn_show.Text = "ไม่มี";
                }
            }
        }

        private void c_n_CheckedChanged(object sender, EventArgs e)
        {
            if(c_n.Checked)
            {
                string temp = st.Text.ToLower();
                string temp2 = st_low.Text.ToLower();
                st_index.Text = (temp.IndexOf(temp2, 0) + 1) + "";
            }
            if (st_index.Text != "0")
            {
                cn_show.Text = "มี";
            }
            else
            {
                cn_show.Text = "ไม่มี";
            }
        }
    }
}
