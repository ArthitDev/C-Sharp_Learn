using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class DayName : Form
    {
        public DayName()
        {
            InitializeComponent();
            //getDayName();
            //GradeValue();
            //GetMonth();
            //testLoop();
            //testArrayCount();
            CheckEvenNum();
        }
        /*
        private static void GetMonth()
        {
            int month = 1;
            switch (month)
            {
                case 1: MessageBox.Show("January"); break;
                case 2: MessageBox.Show("February"); break;
                case 3: MessageBox.Show("March"); break;
                case 4: MessageBox.Show("April"); break;
                case 5: MessageBox.Show("May"); break;
                case 6: MessageBox.Show("June"); break;
                case 7: MessageBox.Show("July"); break;
                case 8: MessageBox.Show("August"); break;
                case 9: MessageBox.Show("September"); break;
                case 10: MessageBox.Show("October"); break;
                case 11: MessageBox.Show("November"); break;
                case 12: MessageBox.Show("December"); break;
                default: MessageBox.Show("UnKnow Month"); break;

            }
        }
        *\
        /
        private static void GradeValue()
        {
            string grade = "A";
            switch (grade)
            {
                case "A": MessageBox.Show("4"); break;
                case "B+": MessageBox.Show("3.5"); break;
                case "B": MessageBox.Show("3"); break;
                case "C+": MessageBox.Show("2.5"); break;
                case "C": MessageBox.Show("2"); break;
                case "D": MessageBox.Show("1.5"); break;
                default: MessageBox.Show("F"); break;
            }
        }
    }
}*/
        /*private static void getDayName()
        {
            int no = 1;
            switch (no)
            {
                case 1: MessageBox.Show("วันจันทร์"); break;
                case 2: MessageBox.Show("วันอังคาร"); break;
                case 3: MessageBox.Show("วันพุธ"); break;
                case 4: MessageBox.Show("วันพฤหัส"); break;
                case 5: MessageBox.Show("วันศุกร์"); break;
                case 6: MessageBox.Show("วันเสาร์"); break;
                case 7: MessageBox.Show("วันอาทิตย์"); break;
                default: MessageBox.Show("ไม่มีวันนี้"); break;
            }*/
        /*
        if (no == 1)
        {
            MessageBox.Show("วันจันทร์");
        }
        else
            if (no == 2)
        {
            MessageBox.Show("วันอังคาร");
        }
        else
            if (no == 3)
        {
            MessageBox.Show("วันพุธ");
        }
        else
            if (no == 4)
        {
            MessageBox.Show("วันพฤหัสบดี");
        }
        else
            if (no == 5)
        {
            MessageBox.Show("วันศุกร์");
        }
        else
            if (no == 6)
        {
            MessageBox.Show("วันเสาร์");
        }
        else
            if (no == 7)
        {
            MessageBox.Show("วันอาทิตย์");
        }
        else
        {
            MessageBox.Show("ไม่มีวันนี้");
        }*/
        /*private static void testLoop()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ".Hello World");
            }
        }*/
        private static void testArrayCount()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            for (int i = 1; i < data.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void CheckEvenNum()
        {
            int num = 199;
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
