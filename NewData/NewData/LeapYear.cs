using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewData
{
    public partial class LeapYear : Form
    {
        public LeapYear()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int year = 1900;
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
    }
}
