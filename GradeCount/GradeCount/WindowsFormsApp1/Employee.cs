using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        String[] id = { "001", "002", "003", "004", "005", "006", "007", "008", "009" ,"0010" };
        String[] name = { "AAA", "BBB", "CCC", "DDD", "EEE", "FFF", "GGG", "TTT", "HHH", "KKK" };
        Char[] sex = { 'F', 'M', 'F', 'M', 'M', 'M', 'M', 'F', 'M', 'F' };
        int[] department = { 1, 2, 4, 2, 3, 1, 4, 2, 3, 4 };
        int[] salary = { 30000, 20000, 15000, 10000, 20000, 14000, 12000, 18000, 40000, 11000};

        public Employee()
        {
            InitializeComponent();
            showDate();
            SexF();
            list30kUp();
            SumSalary();
            EmploySex();
            EmployDepart();
            SumSalaryDepart();
            AvgSalaryDe();
        }
        private void showDate()
        {
            //แสดงข้อมูลทั้งหมด
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine(id[i] + "\t" + name[i] + "\t" + sex[i] + "\t" + department[i] + "\t"+ salary[i]);
            }
        }
        private void SexF()
        {
            //แสดงข้อมูลพนักงานเพศหญิง
            for(int i = 0; i < sex.Length; i++)
            {
                if(sex[i] == 'F')
                {
                    Console.WriteLine((i + 1) + "." + id[i] + "\t" + name[i] + "\t" + sex[i] + "\t" + department[i] + "\t" + salary[i]);
                }
            }
        }
        private void list30kUp()
        {
            //เงินเดือน 30K ขึ้นไป
            for (int i = 0; i < salary.Length; i++)
            {
                if (salary[i] >= 30000)
                {
                    Console.WriteLine((i + 1) + "." + id[i] + "\t" + name[i] + "\t" + sex[i] + "\t" + department[i] + "\t" + salary[i]);
                }
            }
        }
        private void SumSalary()
        {
            //รวมเงินเดือน
            int sum = 0;
            for (int i = 0; i < salary.Length; i++)
            {
                sum = sum + salary[i];
            }
            Console.WriteLine("เงินเดือนทั้งหมด :"+sum);
        }
        private void EmploySex()
        {
            //นับจำนวนพนักงานแยกตามเพศ
            int sexM = 0;
            int sexF = 0;
            for (int i = 0; i < sex.Length; i++)
            {
                if (sex[i] == 'F')
                {
                    sexF++;
                }
                else sexM++;
            }
            Console.WriteLine("เพศชายทั้งหมด :"+sexM);
            Console.WriteLine("เพศหญิงทั้งหมด :"+sexF);
        }
        private void EmployDepart()
        {
            //พนักงานแต่ละแผนก
            int[] CountEm = { 0, 0, 0, 0 };
            for (int i = 0; i < department.Length; i++)
            {
             if (department[i] == 1)
                {
                    CountEm[0]++;
                }
                else if (department[i] == 2)
                {
                    CountEm[1]++;
                }
                else if (department[i] == 3)
                {
                    CountEm[2]++;
                }
                else if (department[i] == 4)
                {
                    CountEm[3]++;
                }     
            }
            for (int i = 0; i < CountEm.Length; i++)
            Console.WriteLine("พนักงานแผนกที่." + (i + 1) + CountEm[i]);
        }
        private void SumSalaryDepart()
        {
            //รวมเงินเดือนแยกตามแผนก
            int[] sum = { 0, 0, 0, 0 };
            for (int i = 0; i < id.Length; i++)
            {
                int j = department[i] - 1;
                sum[j] = sum[j] + salary[i];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine("เงินเดือนรวมของแผนกที่ : "+(i+1)+sum[i]);
            } 
        }
        private void AvgSalaryDe()
        {
            //สูตรจากเงินเดือนแยกตามแผนก
            int[] sum = { 0, 0, 0, 0 };
            for (int i = 0; i < id.Length; i++)
            {
                int j = department[i] - 1;
                sum[j] = sum[j] + salary[i];
            }
            //สูตรนับคนแยกตามแผนกจากข้างบน
            int[] CountEm = { 0, 0, 0, 0 };
            for (int i = 0; i < department.Length; i++)
            {
                if (department[i] == 1)
                {
                    CountEm[0]++;
                }
                else if (department[i] == 2)
                {
                    CountEm[1]++;
                }
                else if (department[i] == 3)
                {
                    CountEm[2]++;
                }
                else if (department[i] == 4)
                {
                    CountEm[3]++;
                }
            }
            for (int i = 0; i < CountEm.Length; i++)
            {
                double avg = sum[i] * 1.0 / CountEm[i];
                Console.WriteLine("เงินเดือนเฉลี่ยแยกตามแผนกที่ : " + (i + 1) + avg);
            }
        }
    }
}
