using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int moneyVat;
            int income;
            int vat;
            income = Convert.ToInt16(textBox1.Text);
            vat = income * 5 / 100;
            moneyVat = income - vat;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
