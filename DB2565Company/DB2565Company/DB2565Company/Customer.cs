using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB2565Company
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        int c = 0;

        private void CLOSE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close ? ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }   
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            id_number.Clear();
            customer_name.Clear();
            location_name.Clear();
            phone_number.Clear();
            id_number.Focus();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.RowCount - 1;
            dataGridView1.RowCount++;
            dataGridView1.Rows[r].Cells[0].Value = id_number.Text;
            dataGridView1.Rows[r].Cells[1].Value = customer_name.Text;
            dataGridView1.Rows[r].Cells[2].Value = location_name.Text;
            dataGridView1.Rows[r].Cells[3].Value = phone_number.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            c = r;
            id_number.Text = dataGridView1[0, r].Value +"";
            customer_name.Text = dataGridView1[1, r].Value +"";
            location_name.Text = dataGridView1[2, r].Value + "";
            phone_number.Text = dataGridView1[3, r].Value + "";
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
         
            dataGridView1.Rows[c].Cells[0].Value = "";

        }
        private void UPDATE_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[c].Cells[0].Value = id_number.Text;
            dataGridView1.Rows[c].Cells[1].Value = customer_name.Text;
            dataGridView1.Rows[c].Cells[2].Value = location_name.Text;
            dataGridView1.Rows[c].Cells[3].Value = phone_number.Text;
        }
    }
}
