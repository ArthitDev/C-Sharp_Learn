using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _641413017
{
    public partial class FinalTest : Form
    {
        public FinalTest()
        {
            InitializeComponent();
            Show_EvenNumber();
            Show_Char_A_Z();
            Show_Piramid();
            Show_StuID();
            //int Show_Degit = GetDegit(1473,0);
            //Console.Write("\n" + Show_Degit);
            //int ans = toNine(1473);
            //Console.WriteLine("\n" + ans);
            //double Unit = Check_electric_1(10);
            //Console.WriteLine(Unit);
            //double Unit2 = Check_electric_2(10);
            //Console.WriteLine(Unit2);
        }
        private void Show_EvenNumber() //โชว์เลขคู่ 100 - 2 แบบบรรทัด
        {
            for(int i = 100; i >= 1 ; i = i - 2)
            {
                if (i % 20 == 0)
                Console.WriteLine();
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");
        }
        private void Show_Char_A_Z() //โชว์ Z - A
        {
            char Show = 'A';
            for(Show = 'Z'; Show >='A'; Show--)
            {
                Console.WriteLine(Show);
            }
            Console.WriteLine("\n");
        }
        private void Show_StuID() //แสดงชื่อ
        {
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("641413017 อาทิตย์ ลุงหยะ");
                        Console.Write("\t");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("641413017 อาทิตย์ ลุงหยะ");
                        Console.Write("\t\t");
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("641413017 อาทิตย์ ลุงหยะ");
                        Console.Write("\t\t\t");
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("641413017 อาทิตย์ ลุงหยะ");
                        Console.Write("\t\t\t\t");
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine("641413017 อาทิตย์ ลุงหยะ");
                        Console.Write("\t\t\t\t\t");
                    }
                }
        }
        }
        private void Show_Piramid() //แสดงเลขแบบพิรามิด
        {
            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
        private int GetDegit(int x, int y) //หาตำแหน่งหลักต่างๆ
        {
            for (int i = 1; i < y - 1; i++)
                x /= 10;
            return x % 10;
        }
        private int toNine(int Num) //แปลงฐาน 2 ไปฐาน 10 
        {
            int Convert_Nine = 0;
            int Base = 1;
            while (Num > 0)
            {
                int reminder = Num % 10;
                Num = Num / 10;
                Convert_Nine += reminder * Base;
                Base = Base * 9;
            }
            return Convert_Nine;
        }
    }
}
