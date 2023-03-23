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
    public partial class Evaluation : Form
    {
        String[] sex = new String[100];
        String[] emloyment = new String[100];
        String[] salary = new String[100];
        String[] content = new String[100];
        int people = 0;
        public Evaluation()
        {
            InitializeComponent();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void bNew_Click(object sender, EventArgs e)
        {
            male.Checked = false;
            female.Checked = false;
            gEmployment.Text = "";
            salary1.Checked = false;
            salary2.Checked = false;
            salary3.Checked = false;
            salary4.Checked = false;
            content5.Checked = false;
            content4.Checked = false;
            content3.Checked = false;
            content2.Checked = false;
            content1.Checked = false;
        }
    

        private void employment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (male.Checked == true)
            {
                sex[people] = "เพศ : ชาย";
            }
            else
                if (female.Checked == true)
            {
                sex[people] = "เพศ : หญิง";
            }
            emloyment[people] = gEmployment.Text;

            if (salary1.Checked == true)
            {
                salary[people] = "เงินเดือนต่ำกว่า : 15000";
            }
            else
                if (salary2.Checked == true)
            {
                salary[people] = "เงินเดือน : 15001-20000";
            }
            else
                if (salary3.Checked == true)
            {
                salary[people] = "เงินเดือน : 20001-40000";
            }
            else
                if (salary4.Checked == true)
            {
                salary[people] = "มากว่า : 40000";
            }

            if (content5.Checked == true)
            {
                content[people] ="ความพึงพอใจ : 5";
            }
            if (content4.Checked == true)
            {
                content[people] = "ความพึงพอใจ : 4";
            }
            if (content3.Checked == true)
            {
                content[people] = "ความพึงพอใจ : 3";
            }
            if (content2.Checked == true)
            {
                content[people] = "ความพึงพอใจ : 2";
            }
            if (content1.Checked == true)
            {
                content[people] = "ความพึงพอใจ : 1";
            }
            people++;
        }

            private void bShow_Click(object sender, EventArgs e)
            {
            String[] ms = new String[100];
            String ms_all = null;
                //if (male.Checked == true)
                //{
                //    ms = ms + "เพศ : ชาย";
                //}
                //else
                //    if (female.Checked == true)
                //{
                //    ms = ms + "เพศ : หญิง";
                //}

                //ms = ms + "\n" + "อาชีพ : " + gEmployment.Text + "\n";
                //if (salary1.Checked == true)
                //{
                //    ms = ms + "'เงินเดือนต่ำกว่า : 15000";
                //}
                //else
                //    if (salary2.Checked == true)
                //{
                //    ms = ms + "'เงินเดือน : 15001-20000";
                //}
                //else
                //    if (salary3.Checked == true)
                //{
                //    ms = ms + "'เงินเดือน : 20001-40000";
                //}
                //else
                //    if (salary4.Checked == true)
                //{
                //    ms = ms + "มากว่า : 40000";
                //}
                //ms = ms + "\n";
                //if (content5.Checked == true)
                //{
                //    ms = ms + "ความพึงพอใจ : 5";
                //}
                //if (content4.Checked == true)
                //{
                //    ms = ms + "ความพึงพอใจ : 4";
                //}
                //if (content3.Checked == true)
                //{
                //    ms = ms + "ความพึงพอใจ : 3";
                //}
                //if (content2.Checked == true)
                //{
                //    ms = ms + "ความพึงพอใจ : 2";
                //}
                //if (content1.Checked == true)
                //{
                //    ms = ms + "ความพึงพอใจ : 1";
                //}
                

            for (int i=0; i<=people; i++)
            {
                ms[i] = ms[i] + sex[i] + " " + emloyment[i] + " " + salary[i] + " " + content[i];
                ms_all = ms_all + ms[i] + "\n";
            }
            MessageBox.Show(ms_all);
        }

            private void bReport_Click(object sender, EventArgs e)
            {
            int f = 0; int m = 0; int elm = 0;
            for(int i=0; i<=people; i++)
            {
                if( sex[i] == "เพศ : ชาย")
                {
                    m++;
                }
                else
                    if(sex[i] == "เพศ : หญิง")
                {
                    f++;
                }
            }
            int elm1 = 0; int elm2 = 0; int elm3 = 0; int elm4 = 0; int elm5 = 0;
                for (int i=0;i<=people;i++)
                {
                    switch(emloyment[i])
                    {
                        case "นักเรียน-นักศึกษา" : elm1++; break;
                        case "รับราชการ " : elm2++; break;
                        case "พนักงานบริษัท/ห้างร้าน": elm3++; break;
                        case "ธุรกิจส่วนตัว/ค้าขาย":elm4++; break;
                        case "ไลน์แมน":elm5++; break;
                    }
                }
            int sly1 = 0; int sly2 = 0; int sly3 = 0; int sly4 = 0;
                for (int i =0;i<=people;i++)
                {
                    switch(salary[i])
                    {
                        case "เงินเดือนต่ำกว่า : 15000" : sly1++; break;
                        case "เงินเดือน : 15001-20000" : sly2++; break;
                        case "เงินเดือน : 20001-40000" : sly3++; break;
                        case "มากว่า : 40000" : sly4++; break;
                    }
                }
            int ct5 = 0; int ct4 = 0; int ct3 = 0; int ct2 = 0; int ct1 = 0;
                for(int i=0; i<=people;i++)
                {
                    switch (content[i])
                    {
                    case "ความพึงพอใจ : 5": ct5++; break;
                    case "ความพึงพอใจ : 4": ct4++; break;
                    case "ความพึงพอใจ : 3": ct3++; break;
                    case "ความพึงพอใจ : 2": ct2++; break;
                    case "ความพึงพอใจ : 1": ct1++; break;
                    }
                }
            string ms_total = null;
            ms_total = ms_total+"เพศ : หญิง "+ f +"เพศ : ชาย "+ m +"\n"
                +"นักเรียน-นักศึกษา : "+ elm1 +"\n"+"รักราชการ : "+ elm2 +"\n"+"พนักงงานบริษัท : "+ elm3 +"\n"+ "ธุรกิจส่วนตัว/ค้าขาย : "+ elm4+"\n" 
                + "เงินเดือนต่ำกว่า : 15000 : "+ sly1 +"\n"+ "เงินเดือน : 15001-20000 : " + sly2 +"\n"+ "เงินเดือน : 20001-40000 : " + sly3 +"\n"+ "มากว่า : 40000 : " + sly4 +"\n"+
               "ความพึงพอใจ 5 : "+ ct5+"\n" + "ความพึงพอใจ 4 : "+ ct4 +"\n"+"ความพึงพอใจ 3 : "+ct3 +"\n"+ "ความพึงพอใจ 2 : "+ ct2 +"\n"+ "ความพึงพอใจ 1 : "+ ct1;
            MessageBox.Show(ms_total);
            }

            private void bExit_Click(object sender, EventArgs e)
            {
            this.Dispose();
            }
    }
}