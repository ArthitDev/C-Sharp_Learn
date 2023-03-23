using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_641413017
{
    public partial class Grid_DB : Form
    {
        public Grid_DB()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.RowCount+"");
            int r = dataGridView1.RowCount - 1;
            dataGridView1.RowCount++;
            dataGridView1.Rows[r].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[r].Cells[1].Value = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Clear ? ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
            }      
        }
    }
}
