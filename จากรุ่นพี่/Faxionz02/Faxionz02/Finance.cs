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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            Console.WriteLine(bahttotext(1500));
            
            tAmount.Enabled = false;
            tNum_Of_Periods.Enabled = false;
            tAnnuity.Enabled = false;
            tRate_Year.Enabled = false;
            tRate_All.Enabled = false;
            tBalance.Enabled = false;
        }

        private void tPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tDown_pm.Focus();
            }
        }

        private void tDown_pm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int amount = int.Parse(tPrice.Text) - int.Parse(tDown_pm.Text);
                tAmount.Text = amount + "";
                tRate.Focus();
            }

        }

        private void tRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rate_year = int.Parse(tAmount.Text) * int.Parse(tRate.Text) / 100;
                tRate_Year.Text = rate_year + "";
                tAmount_Year.Focus();
            }
        }

        private void tAmount_Year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rate_all = int.Parse(tRate_Year.Text) * int.Parse(tAmount_Year.Text);
                tRate_All.Text = rate_all + "";

                int balance = int.Parse(tAmount.Text) + int.Parse(tRate_All.Text);
                tBalance.Text = balance + "";

                int num_of_periods = int.Parse(tAmount_Year.Text) * 12;
                tNum_Of_Periods.Text = num_of_periods + "";

                int annuity = int.Parse(tAmount.Text) / int.Parse(tNum_Of_Periods.Text);
                tAnnuity.Text = annuity + "";


            }
        }

        private String bahttotext(int money)
        {
            String txt = "";
            String tx = "";
            String[] textOfNumber = { "หนึ่ง", "สอง", "สาม", "สี", "ห้า", "หก" ,"เจ็ด", "แปด", "เก้า", "สิบ" };
            String[] point = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            int len = money.ToString().Length;
            try
            {
                for (int i = 0; i < money.ToString().Length; i++)
                {
                    String numCh = money.ToString().Substring(i, 1);
                    int num = int.Parse(numCh);
                    len--;
                    tx = tx + textOfNumber[num - 1] + point[len];
                }
                Console.WriteLine(tx);
            }
            catch (Exception) { }
            return tx+"บาทถ้วน";
        }

        private void tNew_Click(object sender, EventArgs e)
        {
            foreach (Control txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = "";
                tPrice.Focus();
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
