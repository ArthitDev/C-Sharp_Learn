using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace งานใหม่
{
    public partial class NewWork : Form
    {
        public NewWork()
        {
            InitializeComponent();
            //ShowEvenNumber(10);                 //แสดงเลขคู่
            //int ansSum = SumNumber(10);         //บวกเลขตั้งแต่ 1 - n
            //Console.WriteLine(ansSum);          //output
            //int ansSum_2 = SumNumber_2(1, 10);  //บวกเลขตั้งแต่ a - n
            //Console.WriteLine(ansSum_2);        //output
            //double Avg = AvgNumber(1, 100);     //หาค่าเฉลี่ยของตัวเลขตั้งแต่ a - n
            //Console.WriteLine(Avg);             //output
            //ShowName(10);                       //แสดงชื่อนักศึกษา n ครั้ง
            //int ansPower = NumPower(2, 5);      //หาค่า x กำลัง y
            //Console.WriteLine(ansPower);        //output
            //isEvenNumber(2);                    //ตรวจสอบเลขคู่หรือคี่ หากคู่ = True หากคี่ = False
            //int ans = getLengthNumber(1111111111); //หาจำนวนหลักของชุดตัวเลข
            //Console.WriteLine(ans);                //output
            //int Binaly = toBinaly(200);               //แปลงเลขฐาน 10 ให้เป็นเลขฐาน 2
            //Console.WriteLine(Binaly);               //output
            //isEvenNumber_2(3);                       //แบบไม่คืนค่า คืนแค่ เลข
            //string Check = isEvenNumber_3(5);          //แบบคืนค่า T และ F
            //Console.WriteLine(Check);                  //output
            showData(); //แสดงเลขจากหลังมาหน้า            //แสดงจากมากมาน้อย
            //String ans = decimalToOctal(15);          //แปลงฐาน 10 ไปฐาน 8
            //Console.WriteLine(ans);                   //output
            //string ans_2 = decimalToHexa(60395);        //แปลงฐาน 10 ไปฐาน 16
            //Console.WriteLine(ans_2);                   //output
            //int Stamp = getStamp(1000);
            //Console.WriteLine("ได้รับสแตมป์ " + Stamp + " ดวง ");
            //bool Check = isAlphabet('A');
            //Console.WriteLine(Check);
            //bool Show_bool = isLdeapYear(1999);
            //Console.WriteLine(Show_bool);
            //int Day = getDayOfMonth(2,2564);
            //Console.WriteLine(Day + "วัน");
            //ShowPrimeNumber(100);
            //int Show_Degit = GetDegit(2468,2);
            //Console.WriteLine(Show_Degit);
            //int ans = toDecimal(10101);
            //Console.WriteLine(ans);

        }
        private void ShowEvenNumber(int n) //แสดงเลขคู่ตั้งแต่ 1 - n
        {
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        private int SumNumber(int n) //บวกเลขตั้งแต่ 1 - n
        {
            int SumNum = 0;
            for (int i = 1; i <= n; i++)
            {
                SumNum = SumNum + i;
            }
            return SumNum;
        }
        private int SumNumber_2(int a,int n) //บวกเลขตั้งแต่ a - n
        {
            int SumNum_2 = 0;
            for(int i = a; i <= n; i++)
            {
                SumNum_2 = SumNum_2 + i;
            }
            return SumNum_2;
        }
        private Double AvgNumber(int a, int n) //หาค่าเฉลี่ยของตัวเลขตั้งแต่ a - n
        {
            int sum = SumNumber_2(a, n);
            int lengthNum = n - a + 1;
            return sum * 1.0 / lengthNum;
        }
        private void ShowName(int n) //แสดวงชื่อนักศึกษา n ครั้ง
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("อาทิตย์ ลุงหยะ");
            }
        }
        private int NumPower(int x,int y) //หาค่า x กำลัง y
        {
            int NumPower = 1;
            for(int i = 1; i <= y; i++)
            {
                NumPower = NumPower * x;
            }
            return NumPower;
        }
        private bool isEvenNumber(int number) //ตรวจสอบเลขคู่หรือคี่ 
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        private int isEvenNumber_2(int number) //ตรวจสอบเลขคู่หรือคี่ แบบคืนค่าตัวเลข
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
            return number;
        }
        private string isEvenNumber_3(int number) //ตรวจสอบเลขคู่หรือคี่ แบบคืนค่าตัวเลข
        {
            if (number % 2 == 0)
            {
                return "True";
            }
            else
            {
                return "False";
            }
        }   
        private int getLengthNumber(int number) //หาจำนวนหลักของตัวเลข
        {
            int No = 1;
            int CountNum = 0;
            while (No <= number)
            {
                CountNum++;
                No = No * 10;
            }
            return CountNum;
        }
        private int toBinaly(int number) //แปลงเลขฐาน 10 ไป ฐาน 2
        {
            int Convert_Binaly = 0;
            int No = 1;
            for(int i = number; i > 0; i = i /2)
            {
                Convert_Binaly = Convert_Binaly + (number % 2) * No;
                No = No * 10;
                number = number / 2;

            }
            return Convert_Binaly;
        }
        private void showData() //แสดงเลขหลังสุดมาหน้าสุด
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = data.Length-1; i >=0; i--)
            {
                Console.WriteLine(data[i]);
            }
        }
        private string decimalToOctal(int number) //แปลงเลขฐาน 10 เป็นฐาน 8
        {
            String result = "";
            do
            {
                int After_mod = number % 8;
                result = After_mod + result;
                number = number / 8;
            } while (number > 0);
            return result;
        }
        private string decimalToHexa(int number) //แปลงเลขฐาน 10 เป็นฐาน 16
        {
            String result = "";
            do
            {
                int After_mod = number % 16;
                if(After_mod < 10)
                {
                    result = After_mod + result;
                }
                else if(After_mod == 10)
                {
                    result = "A" + result;
                }
                else if(After_mod == 11)
                {
                    result = "B" + result;
                }
                else if (After_mod == 12)
                {
                    result = "C" + result;
                }
                else if (After_mod == 13)
                {
                    result = "D" + result;
                }
                else if (After_mod == 14)
                {
                    result = "E" + result;
                }
                else if (After_mod == 15)
                {
                    result = "F" + result;
                }
                number = number / 16;
            } while (number > 0);
            return result;
        }
        private int getStamp(int Sales)
        {
            int[] Stamp = { 0, 0, 0, 0 ,0 };
            if (Sales >= 1 && Sales <= 79)
            {
                Stamp[0] = Stamp[0] + 1;
                return Stamp[0];
            }
            else if (Sales >= 80 && Sales <= 129)
            {
                Stamp[1] = Stamp[1] + 2;
                return Stamp[1];
            }
            else if (Sales >= 130 && Sales <= 199)
            {
                Stamp[2] = Stamp[2] + 4;
                return Stamp[2];
            }
            else if (Sales >= 200 && Sales <= 399)
            {
                Stamp[3] = Stamp[3] + 10;
                return Stamp[3];
            }
            else if (Sales > 400)
            {
                Stamp[4] = Stamp[4] + 20;
                return Stamp[4];
            }
            else return 0;
        }
        private bool isAlphabet(Char Check) //ตรวจสอบตัวอักษร
        {
            return (Check >= 'a' && Check <= 'z') || (Check >= 'A' && Check <= 'Z' || Check >= 'ก' && Check <= 'ฮ' || Check >= 1 && Check <= 9);
        }
        private bool isLdeapYear(int Year) 
        {
            if (Year % 400 == 0)
            {
                return true;
            }
            else if (Year % 100 == 0)
            {
                return false;
            }
            else if (Year % 4 == 0)
            {
                return true;
            }
            return false;
        }
        private int getDayOfMonth(int Month,int Year) //แสดงวันตามเดือน
        {
            int[] Day_31 = { 1, 3, 5, 7, 8, 10, 12 };
            int[] Day_30 = { 4, 6, 9, 11 };
            for(int i = 1; i <= Day_31.Length; i++)
            {
                if(Month == Day_31[i-1])
                {
                    return 31;
                }
            }
            for(int i = 1; i <= Day_30.Length; i++)
            {
                if(Month == Day_30[i-1])
                {
                    return 30;
                }
            }
            if (Month == 2 && Year-543 % 4 == 0)
            {
                return 29;
            }
            else return 28;
        }
        private void ShowPrimeNumber(int Number) //แสดงจำนวนเฉพาะ
        {
            int j,i;
            int Num = 1;
            for(i = 2; i <= Number; i++)
            {
                for(j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        Num = 0;
                    }
                }
                if (Num == 1)
                {
                    Console.WriteLine("จำนวนเฉพาะ คือ " + j);
                }
                else Num = 1;
            }
        }
        private int GetDegit(int x,int y) //หาตำแหน่งหลักต่างๆ
        {
            for (int i = 1; i < y - 1; i++)
                x /= 10;
            return x % 10;
        }
        private int toDecimal(int binaly) //แปลงฐาน 2 ไปฐาน 10 
        {
            int Convert_Decimal = 0;
            int Base = 1;
            while (binaly > 0)
            {
                int reminder = binaly % 10;
                binaly = binaly / 10;
                Convert_Decimal += reminder * Base;
                Base = Base * 2;
            }
            return Convert_Decimal;
        }
    }
}
