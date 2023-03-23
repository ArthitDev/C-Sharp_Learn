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
    public partial class Data_Structure : Form
    {
        public Data_Structure()
        {
            InitializeComponent();
            //CheckEvenNum();
            //CheckSex();
            //getDayName();
            //CheckGrade();
            //CheckSpellNum();
            //CheckBaseMoney();
            //GetMonthNumber();
            GetGradeName();
        }
        private static void CheckEvenNum()
        {
            int num = 121;
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        private static void CheckSex()
        {
            char sex = 'f';
            if (sex == 'F' || sex == 'f')
            {
                Console.WriteLine("Female");
            }
            else if (sex == 'M' || sex == 'm')
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("ไม่ระบุ");
            }
        }
        private static void getDayName()
        {
            int no = 1;
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
            }
        }
        private static void CheckGrade()
        {
            int score = 34;
            if (score >= 80)
            {
                Console.WriteLine("A");
            }
            else
                if (score >= 79)
            {
                Console.WriteLine("B+");
            }
            else
                if (score >= 74)
            {
                Console.WriteLine("B");
            }
            else
                if (score >= 69)
            {
                Console.WriteLine("C+");
            }
            else
                if (score >= 59)
            {
                Console.WriteLine("C");
            }
            else
                if (score >= 49)
            {
                Console.WriteLine("D+");
            }
            else
                if (score >= 39)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        private static void CheckSpellNum()
        {
            int num = 1;
            if (num == 1)
            {
                Console.WriteLine("หนึ่ง");
            }
            else if (num == 2)
            {
                Console.WriteLine("สอง");
            }
            else if (num == 3)
            {
                Console.WriteLine("สาม");
            }
            else if (num == 4)
            {
                Console.WriteLine("สี่");
            }
            else if (num == 5)
            {
                Console.WriteLine("ห้า");
            }
            else if (num == 6)
            {
                Console.WriteLine("หก");
            }
            else if (num == 7)
            {
                Console.WriteLine("เจ็ด");
            }
            else if (num == 8)
            {
                Console.WriteLine("แปด");
            }
            else if (num == 9)
            {
                Console.WriteLine("เก้า");
            }
            else
            {
                Console.WriteLine("ให้ใส่เลขแค่ 1 - 9 ");
            }
        }
        private static void CheckBaseMoney()
        {
            int num = 5;
            if (num == 2)
            {
                Console.WriteLine("สิบ");
            }
            else if (num == 3)
            {
                Console.WriteLine("ร้อบ");
            }
            else if (num == 4)
            {
                Console.WriteLine("พัน");
            }
            else if (num == 5)
            {
                Console.WriteLine("หมื่น");
            }
            else if (num == 6)
            {
                Console.WriteLine("แสน");
            }
            else if ( num == 7)
            {
                Console.WriteLine("ล้าน");
            }
            else
            {
                Console.WriteLine("มีแค่ 7 หลัก");
            }
        }
        private static void GetMonthNumber()
        {
            int year = 2543;
            year -= 543;
            int month = 2;
            if (month >= 1 && month <= 12)
            {
                if (year >= 1)
                {
                    if (year % 100 == 0 && year % 400 == 0)
                    {
                        Console.WriteLine("เป็นปีอธิกสุรธิน");
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                        {
                            Console.WriteLine("31 วัน");
                        }
                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            Console.WriteLine("30 วัน");
                        }
                        else if (month == 2)
                        {
                            Console.WriteLine("29 วัน");
                        }
                    }
                    else if (year % 4 == 0 && year % 100 == 0)
                    {
                        Console.WriteLine("ไม่เป็นปีอธิกสุรธิน");
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                        {
                            Console.WriteLine("31 วัน");
                        }
                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            Console.WriteLine("30 วัน");
                        }
                        else if (month == 2)
                        {
                            Console.WriteLine("28 วัน");
                        }
                    }
                    else if (year % 4 == 0)
                    {
                        Console.WriteLine("เป็นปีอธิกสุรธิน");
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                        {
                            Console.WriteLine("31 วัน");
                        }
                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            Console.WriteLine("30 วัน");
                        }
                        else
                        {
                            Console.WriteLine("29 วัน");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ไม่เป็นปีอธิกสุรธิน");
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                        {
                            Console.WriteLine("31 วัน");
                        }
                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            Console.WriteLine("30 วัน");
                        }
                        else if (month == 2)
                        {
                            Console.WriteLine("28 วัน");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ป้อนปีให้มากกว่า 1ปี ขึ้นไป");
                }
            }
            else
            {
                Console.WriteLine("ป้อนเดือนให้อยู่ในช่วง 1 - 12 ");
            }
        }
        private static void GetGradeName()
        {
            int score = 74;
            if (score >= 80)
            {
                Console.WriteLine("A");
            }
            else if (score >= 75)
            {
                Console.WriteLine ("B+");
            }
            else if (score >= 70)
            {
                Console.WriteLine("B");
            }
            else if (score >= 65)
            {
                Console.WriteLine("C+");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C");
            }
            else if (score >= 55)
            {
                Console.WriteLine("D+");
            }
            else if (score >= 50)
            {
                Console.WriteLine("D");
            }
            else if (score >= 34)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
