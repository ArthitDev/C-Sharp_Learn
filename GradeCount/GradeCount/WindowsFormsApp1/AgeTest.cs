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
    public partial class AgeTest : Form
    {
        int[] age = { 1, 40, 20, 70, 55, 45, 66, 88, 99, 54, 33, 22, 11, 77, 55, 44, 33, 89 };
        public AgeTest()
        {
            InitializeComponent();
            //showAge();
            //sumAge();
            //avgAge();
            //countAge();
            //countAge_2();
        }
        private void sumAge()
        {
            //รวมอายุทั้งหมด
            int sum = 0;
            for (int i = 0; i < age.Length; i++)
            {
                sum = sum + age[i];
            }
            Console.WriteLine("อายุรวมทั้งหมด" + sum);
        }
        private void showAge()
        {
            //แสดงอายุทั้งหมด
            for (int i = 0; i < age.Length; i++)
                Console.WriteLine("อายุทั้งหมด = " + age[i]);
        }
        private void avgAge()
        {
            //อายุเฉลี่ยทั้งหมด
            int sum = 0;
            for (int i = 0; i < age.Length; i++)
            {
                sum = sum + age[i];
            }
            double avg = sum * 1.0 / age.Length;
            Console.WriteLine("อายุเฉลี่ยทั้งหมด = " + avg);
        }
        private void countAge()
        {
            //นับอายุทั้งหมด
            int[] count = { 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] >= 1 && age[i] <= 9)
                    count[0]++;
                else if (age[i] >= 10 && age[i] <= 19)
                    count[1]++;
                else if (age[i] >= 20 && age[i] <= 29)
                    count[2]++;
                else if (age[i] >= 30 && age[i] <= 39)
                    count[3]++;
                else if (age[i] >= 40 && age[i] <= 49)
                    count[4]++;
                else if (age[i] >= 50 && age[i] <= 59)
                    count[5]++;
                else if (age[i] >= 60)
                    count[6]++;
            }
            Console.WriteLine("อายุ 1 - 9  = " + count[0]);
            Console.WriteLine("อายุ 10 - 19 = " + count[1]);
            Console.WriteLine("อายุ 20 - 29 = " + count[2]);
            Console.WriteLine("อายุ 30 - 39 = " + count[3]);
            Console.WriteLine("อายุ 40 - 49 = " + count[4]);
            Console.WriteLine("อายุ 50 - 59 = " + count[5]);
            Console.WriteLine("อายุ 60 ขึ้นไป = " + count[6]);
        }
        private void countAge_2()
        {
            //นับจำนวนคนแยกตามช่วงอายุ 1-9,10-19,20-29,30-39,40-49,50-59,60+
            int[] c = { 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < age.Length; i++)
            {
                int d = age[i] / 10;
                if (d > 6)
                {
                    d = 6;
                }
                c[d]++;

            }
            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
