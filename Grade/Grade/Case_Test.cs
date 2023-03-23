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
    public partial class Case_Test : Form
    {
        public Case_Test()
        {
            InitializeComponent();
            //Day_Name();
            //Grade_Point();
            //Day_in_Month();
            //Spell_Num();
            //Base_Money();
            //Array_count();
            //loop_1_10_While();
            //loop_1_10_Do();
            //loop_Even_While();
            //loop_Even_Do();
            //loop_1_10_For();
            //loop_10_1_For();
            //Sum_Number();
            //Show_A_Z();
            //Show_Z_A();
            //Multi_7();
            //Array_Day_Month();
            //CountVote();
            //ShowCharInString();

        }
        private static void Day_Name()
        {
            int Day = 1;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("วันจันทร์");
                    break;
                case 2:
                    Console.WriteLine("วันอังคาร");
                    break;
                case 3:
                    Console.WriteLine("วันพุธ");
                    break;
                case 4:
                    Console.WriteLine("วันพฤหัสบดี");
                    break;
                case 5:
                    Console.WriteLine("วันศุกร์");
                    break;
                case 6:
                    Console.WriteLine("วันเสาร์");
                    break;
                case 7:
                    Console.WriteLine("วันอาทิตย์");
                    break;
                default:
                    Console.WriteLine("ไม่มัวันนี้");
                    break;
            }
        }
        private static void Grade_Point()
        {
            string grade = "A";
            switch (grade)
            {
                case "A":
                    Console.WriteLine("4");
                    break;
                case "B+":
                    Console.WriteLine("3.5");
                    break;
                case "B":
                    Console.WriteLine("3");
                    break;
                case "C+":
                    Console.WriteLine("2.5");
                    break;
                case "C":
                    Console.WriteLine("2");
                    break;
                case "D+":
                    Console.WriteLine("1.5");
                    break;
                case "D":
                    Console.WriteLine("1");
                    break;
                case "F":
                    Console.WriteLine("0");
                    break;
            }
        }
        private static void Day_in_Month()
        {
            int year = 2543;
            int month = 1;
            year -= 543;
            switch (year % 4 == 0)
            {
                case true:
                    {
                        if (year % 400 == 0 && year % 100 == 0)
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
                        break;
                    }
                case false:
                    {
                        if (year % 4 == 0 && year % 100 == 0)
                        {
                            Console.WriteLine("ไม่เป็นเป็นปีอธิกสุรธิน");
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
                        break;
                    }
            }
        }

        private static void Spell_Num()
        {
            int Num = 1;
            switch (Num)
            {
                case 1:
                    Console.WriteLine("หนึ่ง");
                    break;
                case 2:
                    Console.WriteLine("สอง");
                    break;
                case 3:
                    Console.WriteLine("สาม");
                    break;
                case 4:
                    Console.WriteLine("สี่");
                    break;
                case 5:
                    Console.WriteLine("ห้า");
                    break;
                case 6:
                    Console.WriteLine("หก");
                    break;
                case 7:
                    Console.WriteLine("เจ็ด");
                    break;
                case 8:
                    Console.WriteLine("แปด");
                    break;
                case 9:
                    Console.WriteLine("เก้า");
                    break;
                default:
                    Console.WriteLine("มีแค่ 1 - 9 ");
                    break;
            }
        }
        private static void Base_Money()
        {
            int Base = 2;
            switch (Base)
            {
                case 2:
                    Console.WriteLine("สิบ");
                    break;
                case 3:
                    Console.WriteLine("ร้อย");
                    break;
                case 4:
                    Console.WriteLine("พัน");
                    break;
                case 5:
                    Console.WriteLine("หมื่น");
                    break;
                case 6:
                    Console.WriteLine("แสน");
                    break;
                case 7:
                    Console.WriteLine("ล้าน");
                    break;
                default:
                    Console.WriteLine("ถึงแค่หลักล้าน");
                    break;
            }
        }
        private static void loop_1_10_While()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        private static void loop_1_10_Do()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
        }
        private static void loop_Even_While()
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
        private static void loop_Even_Do()
        {
            int i = 2;
            do
            {
                Console.WriteLine(i);
                i += 2;
            }
            while (i <= 20);
        }
        private static void loop_1_10_For()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void loop_10_1_For()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        private static void Sum_Number()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        private static void Show_A_Z()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void Show_Z_A()
        {
            for (char i = 'Z'; i <= 'A'; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static void Multi_7()
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = i * 7;
                Console.WriteLine(7 + " x " + i + " = " + result);
            }
        }
        private static void Array_Day_Month()
        {
            string[] dayName = { "วันจันทร์", "วันอังคาร", "วันพุธ", "วันพฤหัสบดี", "วันศุกร์", "วันเสาร์", "วันอาทิตย์" };
            int day = 1;
            int num = 0;
            try
            {
                Console.WriteLine(dayName[day - 1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Unknow");
            }
            for (int i = 0; i < dayName.Length; i++)
            {
                num = i;
            }
            Console.WriteLine(num+1);
        }
        private static void CountVote()
        {
            int[] data = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 2, 4, 5, 2, 5, 1, 2, 3, 4, 2, 1, 2, 4, 2, 1, 4, 1, 4, 2, 3, 3, 5, 4, 1, 2, 3, 4, 5, 5, 4, 3, 2, 1 };
            int[] c = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < data.Length; i++)
            {
                int k = data[i];
                switch (k)
                {
                    case 1: c[0]++; break;
                    case 2: c[1]++; break;
                    case 3: c[2]++; break;
                    case 4: c[3]++; break;
                    case 5: c[4]++; break;
                }
            }
            string ms = "";
            for (int i = 0; i < c.Length; i++)
            {
                ms = ms + c[i] + "\n";
                //Console.WriteLine("เลข " + (i+1) + " มีจำนวน : " + c[i] + " ค่า");
            }
            MessageBox.Show("มีจำนวน : " + ms + " โหวต", "จำนวนการโหวต");
        }
        private static void ShowCharInString()
        {
            string st = "ChiangRai";
            //MessageBox.Show(st,"ข้อความ");
            //MessageBox.Show(st.Length.ToString() + " ตัว","อักษรทั้งหมด");
            for (int i = st.Length; i > 0; i--)
            {
                MessageBox.Show(st.Substring(0,i));
            }
        }
    }
}