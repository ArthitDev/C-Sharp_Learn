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
    public partial class RecordEPY : Form
    {
        struct EmployeeRecord
        {
            public String id, name;
            public char sex;
            public String department;
            public int salary;
        }
        int m = 0;

        EmployeeRecord[] employee = new EmployeeRecord[10];


        public RecordEPY()
        {
            InitializeComponent();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            Tid.Clear();
            Tname.Clear();
            male.Checked = false;
            female.Checked = false;
            otter.Checked = false;
            Tdpm.Clear();
            Tsalary.Clear();
            Tid.Focus();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            char sex = ' ';
            if (male.Checked)
                sex = 'M';
            else
                if (female.Checked)
                sex = 'F';
            else
                sex = 'N';
            employee[m].id = Tid.Text;
            employee[m].name = Tname.Text;
            employee[m].sex = sex;
            employee[m].department = Tdpm.Text;
            employee[m].salary = int.Parse(Tsalary.Text);
            m++;
        }
        private void showData()
        {
            for (int i = 0; i < employee.Length; i++)
            {
                MessageBox.Show(employee[i].id + employee[i].name + employee[i].sex + employee[i].department + employee[i].salary);
            }
        }

        private EmployeeRecord searchID(String id)   //ค้นหาข้อมูลพนักงานตามรหัส จะได้คนเดียว
        {
            foreach(EmployeeRecord record in employee)
            {
                if(record.id == id)
                    return record;
            }
            return new EmployeeRecord();
        }

        private int sumSalary()  //รวมเงินเดือนพนักงานทั้งหมด
        {
            int sum = 0;
            for(int i = 0;i < employee.Length;i++)
            {
                sum = sum + employee[i].salary;
            }
            return sum;
        }

        private EmployeeRecord[] searchSex(char sex)  // ค้นหาข้อมูลพนักงานตามเพศ
        {
            int m = 0;
            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].sex == sex)
                {
                    m++;
                }
            }

            EmployeeRecord[] data = new EmployeeRecord[m];

            m = 0;
            for(int i = 0;i < employee.Length;i++)
            {
                if(employee[i].sex == sex)
                {
                    data[m] = employee[i];
                    m++;
                }
            }
            return data;
        }

        private EmployeeRecord[] searchDPM(String department)  //ค้นหาข้อมูลพนักงานคามแผนก จะได้หลายคน
        {
            int m = 0;
            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].department == department)
                {
                    m++;
                }
            }

            EmployeeRecord[] data = new EmployeeRecord[m];

            m = 0;
            for (int i = 0; i < employee.Length; i++)
            {
                if (employee[i].department == department)
                {
                    data[m] = employee[i];
                    m++;
                }
            }
            return data;
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            EmployeeRecord data = searchID(Tid.Text);
            Console.WriteLine(data.id + " " + data.name + " " + data.sex + " " + data.department + " " + data.salary);
            //Tname.Text = employee.name;
            //Tdpm.Text = employee.department;
            //if (employee.sex == 'M')
            //    male.Checked = true;
            //else
            //    if (employee.sex == 'F')
            //    female.Checked = true;
            //else
            //    if (employee.sex == 'N')
            //    otter.Checked = true;
            //Tsalary.Text = employee.salary+"";
        }

        private void bSearchSex_Click(object sender, EventArgs e)
        {
            char sex = 'N';
            if (male.Checked)
            {
                sex = 'M';
            }
            else if (female.Checked)
            {
                sex = 'F';
            }
            else if (otter.Checked)
            {
                sex = 'N';
            }
            EmployeeRecord[] data = searchSex(sex);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i].id + " " + data[i].name + " " + data[i].sex + " " + data[i].department + " " + data[i].salary);
            }
        }

        private void bSearchDPM_Click(object sender, EventArgs e)
        {

        }

        private void bSum_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sumSalary());
        }
    }
}
