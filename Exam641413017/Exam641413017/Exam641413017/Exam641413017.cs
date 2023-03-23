using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam641413017
{
    public partial class Exam : Form
    {
        string[] Subject = { "Algor", "Com_Ogr", "Connection", "Web_Base", "Animetion", "Big_Data", "Discrete", "Desing_Ui", "Data_Structure", "Data_Base" };
        int[] No = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };
        int[] Lesson = { 4, 4, 3, 4, 4, 4, 4, 3, 5, 2,};
        int[] ID_Teach = { 1, 1, 2, 3, 1, 2, 4, 6, 2, 5, 6, 7, 8, 8, 7, 6, 5, 3, 1, 2, 4, 8, 4, 9, 3, 3, 1, 8, 9 };
        int[] ID_Subject = { 101, 102, 106, 101, 103, 102, 101, 105, 104, 108, 109, 110, 104, 102, 102, 105, 105, 106, 102, 102, 105, 102, 104, 105, 103, 107, 106, 103, 106 };
        int[] Std_Value = { 29, 42, 48, 21, 20, 80, 30, 15, 22, 11, 32, 42, 18, 60, 34, 32, 16, 22, 39, 20, 14, 17, 18, 19, 21, 25, 40, 20, 30 };
        public Exam()
        {
            InitializeComponent();
            //Show_All();
            //Show_Std_50up();
            //Count_Subject();
            //Sum_Lesson();
            //Find_Max_Subject();
            Test_Div();

        }
        private void Show_All()
        {
            //แสดงข้อมูลการสอนทั้ง 29 รายการ
            for(int i = 0; i < No.Length; i++)
            {
                Console.WriteLine(" ลำดับที่." + (i + 1)+" \tรหัสอาจารย์"+ID_Teach[i]+" \tจำนวนนักศึกษา"+Std_Value[i]+" \tรหัสวิชา"+ID_Subject[i]);
            }
        }
        private void Show_Std_50up()
        {
            //แสดงการสอนที่มีนักศึกษา 50 คนขึ้นไป
            for (int i = 0; i < No.Length; i++)
            {
                if(Std_Value[i] >= 50)
                {
                    Console.WriteLine("รหัสอาจารย์" + ID_Teach[i] + " \tจำนวนนักศึกษา" + Std_Value[i] + " \tรหัสวิชา" + ID_Subject[i]);
                }
            }
        }
        private void Count_Subject()
        {
            //นับจำนวนการสอนแยกตามวิชา
            string[] Sub_list = { "Algor", "Com_Ogr", "Connection", "Web_Base", "Animetion", "Big_Data", "Discrete", "Desing_Ui", "Data_Structure", "Data_Base" };
            int[] Count_Sub = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            for(int i = 0; i < No.Length; i++)
            {
                switch (ID_Subject[i])
                {
                    case 101: Count_Sub[0]++; break;
                    case 102: Count_Sub[1]++; break;
                    case 103: Count_Sub[2]++; break;
                    case 104: Count_Sub[3]++; break;
                    case 105: Count_Sub[4]++; break;
                    case 106: Count_Sub[5]++; break;
                    case 107: Count_Sub[6]++; break;
                    case 108: Count_Sub[7]++; break;
                    case 109: Count_Sub[8]++; break;
                    case 110: Count_Sub[9]++; break;
                }
            }
            for (int i = 0; i < Count_Sub.Length; i++)
            {
                Console.WriteLine("วิชา : "+Sub_list[i] + "\tมีจำนวนการสอนทั้งหมด : "+Count_Sub[i]);
            }
        }
        private void Sum_Lesson()
        {
            //รวมจำนวนคาบสอนแยกตามอาจารย์
            int[] Sum_Les = { 0, 0, 0, 0, 0, 0, 0, 0, 0,};
            for(int i = 0; i < No.Length; i++)
            {
                switch (ID_Teach[i])
                {
                    case 1: Sum_Les[0] = Sum_Les[0] + Lesson[i]; break;
                    case 2: Sum_Les[1] = Sum_Les[1] + Lesson[i]; break;
                    case 3: Sum_Les[2] = Sum_Les[2] + Lesson[i]; break;
                    case 4: Sum_Les[3] = Sum_Les[3] + Lesson[i]; break;
                    case 5: Sum_Les[4] = Sum_Les[4] + Lesson[i]; break;
                    case 6: Sum_Les[5] = Sum_Les[5] + Lesson[i]; break;
                    case 7: Sum_Les[6] = Sum_Les[6] + Lesson[i]; break;
                    case 8: Sum_Les[7] = Sum_Les[7] + Lesson[i]; break;
                    case 9: Sum_Les[8] = Sum_Les[8] + Lesson[i]; break;
                    case 10: Sum_Les[9] = Sum_Les[9] + Lesson[i]; break;
                }
            }
            for(int i = 0; i < Sum_Les.Length; i++)
            {
                Console.WriteLine("อาจารย์คนที่." + (i + 1) + Sum_Les[i]);
            }
        }
        private void Find_Max_Subject()
        {
            //หาวิชาที่มีนักศึกษาเรียนมากที่สุด
            int Max_Sub = ID_Subject[0];
            for (int i = 1; i < No.Length; i++)
            {
                if (ID_Subject[i] > Max_Sub)
                {
                    Max_Sub = ID_Subject[i];
                }
            }
            Console.WriteLine("จำนวนมากที่สุด : " + Max_Sub);
        }
        private void Test_Div()
        {
           float Test =  1 / 2;
           Console.WriteLine(Test);

        }
    }
}
