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
    public partial class Survey : Form
    {
        int[] no = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        char[] sex = { 'F', 'M','F', 'F', 'M', 'F', 'M', 'M', 'F', 'F', 'M', 'F', 'F', 'M', 'F', 'F',
                       'M', 'M','F','F', 'M','M','F', 'M','F','M', 'M','M','F', 'M',};
        int[] age = { 20, 21, 22, 25, 28, 25, 25, 20, 28, 35, 24, 20, 25, 27, 28, 29, 33, 75, 55, 45, 43, 33, 31, 29, 36, 75, 60, 62, 66, 30, };
        int[] education = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        int[] income = {10000,12000,13000,14000,15000, 10000, 12000, 13000, 14000, 15000 , 10000, 12000, 13000, 14000, 15000, 10000, 12000, 13000, 14000, 15000,
                        30000,20000,40000,39999,30000,20000,15000,14999,40000,26000};
        int[] value = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        public Survey()
        {
            InitializeComponent();
            //ShowAll();
            //CountSex();
            //ShowEducate();
            //ShowValue();
            //YearLow();
            //IncomeLV();
            //CheckAge();
            //CheckIncome();
            //CheckAgeFormValue();
            //CheckPerValue();
            //ShowMinValue();
            //ShowMaxValue();
            //ShowMinIncome();
            //ShowValueBC_up();
            //Show_HighBC();
            //ShowHigh_Trick();
        }
        private void ShowAll()
        {
            //แสดงข้อมูลทั้งหมดใน 1 บรรทัด
            for (int i = 0; i < sex.Length; i++)
            {
                Console.WriteLine("ชุดที่." + no[i] + "\tเพศ : " + sex[i] + "\tอายุ : " + age[i] + " \tการศึกษา : " + education[i] + "\tรายได้ : " + income[i] + " \tความพึงพอใจ : " + value[i]);
            }
        }
        private void CountSex()
        {
            //แสดงเพศนับแยกชายหญิง
            int M = 0, F = 0;
            for (int i = 0; i < sex.Length; i++)
            {
                if (sex[i] == 'M')
                {
                    M++;
                }
                else
                {
                    F++;
                }
            }
            Console.WriteLine("เพศชายมีทั้งหมด : " + M + "\tเพศหญิงมีทั้งหมด : " + F);
        }
        private void ShowEducate()
        {
            //แสดงระดับการศึกษา
            int[] C = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < sex.Length; i++)
            {
                int inC = education[i];
                C[inC - 1]++;
            }
            Console.WriteLine("ต่ำกว่าอนุปริญญา :" + C[0] + "\tอนุปริญญา : " + C[1] + "\tปริญญาตรี : " + C[2] + "\tปริญญาโท : " + C[3] + "\tปริญญาเอก : " + C[4]);
        }
        private void ShowValue()
        {
            //แสดงระดับความพึงพอใจ
            int[] CountValue = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < sex.Length; i++)
            {
                switch (value[i])
                {
                    case 1: CountValue[0]++; break;
                    case 2: CountValue[1]++; break;
                    case 3: CountValue[2]++; break;
                    case 4: CountValue[3]++; break;
                    case 5: CountValue[4]++; break;
                }
            }
            for (int i = 0; i < CountValue.Length; i++)
            {
                Console.WriteLine("ระดับความพึงพอใจระดับ " + (i + 1) + " : " + CountValue[i]);
            }
        }
        private void YearLow()
        {
            //แสดงอายุตามช่วงอายุ ต่ำกว่า 18,18-22,23-30,31-49,50-59,60 ขั้นไป
            int[] Cage = { 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < sex.Length; i++)
            {
                if (age[i] < 18)
                    Cage[0]++;
                else if (age[i] >= 18 && age[i] <= 22)
                    Cage[1]++;
                else if (age[i] >= 23 && age[i] <= 30)
                    Cage[2]++;
                else if (age[i] >= 31 && age[i] <= 39)
                    Cage[3]++;
                else if (age[i] >= 40 && age[i] <= 49)
                    Cage[4]++;
                else if (age[i] >= 50 && age[i] <= 59)
                    Cage[5]++;
                else Cage[6]++;
            }
            Console.WriteLine("อายุต่ำกว่า 18 ปี : " + Cage[0]);
            Console.WriteLine("อายุ 18-22ปี : " + Cage[1]);
            Console.WriteLine("อายุ 23-30 ปี : " + Cage[2]);
            Console.WriteLine("อายุ 31-29 ปี : " + Cage[3]);
            Console.WriteLine("อายุ 40-49 ปี : " + Cage[4]);
            Console.WriteLine("อายุ 50-59 ปี : " + Cage[5]);
            Console.WriteLine("อายุมากกว่า 60 ปี : " + Cage[6]);
        }
        private void IncomeLV()
        {
            //ช่วงรายได้ ต่ำกว่า 10000, 10001-14999, 15000-19999, 20000-29999, 30000-39999, 40000+
            int[] Cincome = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < sex.Length; i++)
            {
                if (income[i] <= 10000)
                    Cincome[0]++;
                else if (income[i] >= 10001 && income[i] <= 14999)
                    Cincome[1]++;
                else if (income[i] >= 15000 && income[i] <= 19999)
                    Cincome[2]++;
                else if (income[i] >= 20000 && income[i] <= 29999)
                    Cincome[3]++;
                else if (income[i] >= 30000 && income[i] <= 39999)
                    Cincome[4]++;
                else Cincome[5]++;
            }
            Console.WriteLine("รายได้ต่ำกว่า 10000 บาท : " + Cincome[0] + " คน");
            Console.WriteLine("รายได้ 10001-14999 บาท : " + Cincome[1] + " คน");
            Console.WriteLine("รายได้ 15000-19999 บาท : " + Cincome[2] + " คน");
            Console.WriteLine("รายได้ 20000-29999 บาท : " + Cincome[3] + " คน");
            Console.WriteLine("รายได้ 30000-39999 บาท : " + Cincome[4] + " คน");
            Console.WriteLine("รายได้มากกว่า 40000 บาท : " + Cincome[5] + " คน");
        }
        private void CheckAge()
        {
            //อายุเฉลี่ย
            double sumAge = 0, AvgAge = 0;
            for (int i = 0; i < sex.Length; i++)
            {
                sumAge = sumAge + age[i];
            }
            AvgAge = sumAge * 1.0 / age.Length;
            Console.WriteLine("อายุเฉลี่ย : " + AvgAge);
        }
        private void CheckIncome()
        {
            //รายได้เฉลี่ย
            double sumIncome = 0, AvgIncome = 0;
            for (int i = 0; i < sex.Length; i++)
            {
                sumIncome = sumIncome + income[i];
            }
            AvgIncome = sumIncome * 1.0 / income.Length;
            Console.WriteLine("รายได้เฉลี่ย : " + AvgIncome);
        }
        private void CheckAgeFormValue()
        {
            //หาอายุเฉลี่ยแยกตามความพึงพอใจ
            int[] sumAge = { 0, 0, 0, 0, 0 };
            int[] avgAge = { 0, 0, 0, 0, 0 };
            int[] Cvalue = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < age.Length; i++)
            {
                switch (value[i])
                {
                    case 1:
                        Cvalue[0]++;
                        sumAge[0] = sumAge[0] + age[i];
                        avgAge[0] = sumAge[0] / Cvalue[0];
                        break;
                    case 2:
                        Cvalue[1]++;
                        sumAge[1] = sumAge[1] + age[i];
                        avgAge[1] = sumAge[1] / Cvalue[1];
                        break;
                    case 3:
                        Cvalue[2]++;
                        sumAge[2] = sumAge[2] + age[i];
                        avgAge[2] = sumAge[2] / Cvalue[2];
                        break;
                    case 4:
                        Cvalue[3]++;
                        sumAge[3] = sumAge[3] + age[i];
                        avgAge[3] = sumAge[3] / Cvalue[3];
                        break;
                    case 5:
                        Cvalue[4]++;
                        sumAge[4] = sumAge[4] + age[i];
                        avgAge[4] = sumAge[4] / Cvalue[4];
                        break;
                }
            }
            for (int i = 0; i < Cvalue.Length; i++)
            {
                Console.WriteLine("อายุเฉลี่ยของระดับความพึงพอใจ\t" + (i + 1) + " = " + avgAge[i] + " ปี");
            }
        }
        private void CheckPerValue()
        {
            //หาเปอร์เซนต์ตามความพึงพอใจแต่ละระดับ
            double[] PerValue = { 0, 0, 0, 0, 0 };
            double[] Cvalue = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i])
                {
                    case 1: Cvalue[0]++; break;
                    case 2: Cvalue[1]++; break;
                    case 3: Cvalue[2]++; break;
                    case 4: Cvalue[3]++; break;
                    case 5: Cvalue[4]++; break;
                }
            }
            PerValue[0] = Cvalue[0] * 100 / no.Length;
            PerValue[1] = Cvalue[1] * 100 / no.Length;
            PerValue[2] = Cvalue[2] * 100 / no.Length;
            PerValue[3] = Cvalue[3] * 100 / no.Length;
            PerValue[4] = Cvalue[4] * 100 / no.Length;

            for (int i = 0; i < PerValue.Length; i++)
            {
                Console.WriteLine("เปอเซ็นต์ความพึงพอใจระดับที่." + (i + 1) + " คือ : " + PerValue[i] + " เปอเซ็นต์");
            }
        }
        private void ShowMinValue()
        {
            //ระดับความพึงพอใจที่มีผู้คนออกความคิดเห็นน้อยที่สุด
            int[] Cvalue = { 0, 0, 0, 0, 0, };
            for (int i = 0; i < no.Length; i++)
            {
                switch (value[i])
                {
                    case 1: Cvalue[0]++; break;
                    case 2: Cvalue[1]++; break;
                    case 3: Cvalue[2]++; break;
                    case 4: Cvalue[3]++; break;
                    case 5: Cvalue[4]++; break;
                }
            }
            if (Cvalue[0] < Cvalue[1] && Cvalue[0] < Cvalue[2] && Cvalue[0] < Cvalue[3] && Cvalue[0] < Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นน้อยที่สุด คือ 1");
            }
            else if (Cvalue[1] < Cvalue[2] && Cvalue[1] < Cvalue[3] && Cvalue[1] < Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นน้อยที่สุด คือ 2");
            }
            else if (Cvalue[2] < Cvalue[3] && Cvalue[2] < Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นน้อยที่สุด คือ 3");
            }
            else if (Cvalue[3] < Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นน้อยที่สุด คือ 4");
            }
            else if (Cvalue[4] < Cvalue[3])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นน้อยที่สุด คือ 5");
            }
            else Console.WriteLine("ความพึงพอใจมีความเห็นเท่ากันทั้งหมด");
        }
        private void ShowMaxValue()
        {
            //ระดับความพึงพอใจที่มีผู้คนออกความคิดเห็นมากที่สุด
            int[] Cvalue = { 0, 0, 0, 0, 0, };
            for (int i = 0; i < no.Length; i++)
            {
                switch (value[i])
                {
                    case 1: Cvalue[0]++; break;
                    case 2: Cvalue[1]++; break;
                    case 3: Cvalue[2]++; break;
                    case 4: Cvalue[3]++; break;
                    case 5: Cvalue[4]++; break;
                }
            }
            if (Cvalue[0] > Cvalue[1] && Cvalue[0] > Cvalue[2] && Cvalue[0] > Cvalue[3] && Cvalue[0] > Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นมากที่สุด คือ 1");
            }
            else if (Cvalue[1] > Cvalue[2] && Cvalue[1] > Cvalue[3] && Cvalue[1] > Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นมากที่สุด คือ 2");
            }
            else if (Cvalue[2] > Cvalue[3] && Cvalue[2] > Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นมากที่สุด คือ 3");
            }
            else if (Cvalue[3] > Cvalue[4])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นมากที่สุด คือ 4");
            }
            else if (Cvalue[4] > Cvalue[3])
            {
                Console.WriteLine("ความพึงพอใจระดับที่มีคนออกความเห็นมากที่สุด คือ 5");
            }
            else Console.WriteLine("ความพึงพอใจมีความเห็นเท่ากันทั้งหมด");
        }
        private void ShowMinIncome()
        {
            //แสดงเงินเดือนที่ต่ำที่สุด
            int min = income[0];
            for (int i = 0; i < no.Length; i++)
            {
                if (min > income[i])
                {
                    min = income[i];
                }
            }
            Console.WriteLine("เงินเดือนต่ำที่สุดคือ :" + min);
        }
        private void ShowValueBC_up()
        {
            //แสดงความเห็นของคนที่จบปริญญาตรีขึ้นไป
            for(int i = 0; i < no.Length; i++)
            {
                if(education[i] >= 3)
                {
                    Console.WriteLine("\tเพศ : " + sex[i] + "\tอายุ : " + age[i] + " \tการศึกษา : " + education[i] + "\tรายได้ : " + income[i] + " \tความพึงพอใจ : " + value[i]);
                }
            }
        }
        private void Show_HighBC()
        {
            //แสดงระดับการศึกษาที่มีคนกรอกมากที่สุด
            int[] Cedu = { 0, 0, 0, 0, 0, };
            for (int i = 0; i < no.Length; i++)
            {
                switch (education[i])
                {
                    case 1: Cedu[0]++; break;
                    case 2: Cedu[1]++; break;
                    case 3: Cedu[2]++; break;
                    case 4: Cedu[3]++; break;
                    case 5: Cedu[4]++; break;
                }
            }
            if (Cedu[0] > Cedu[1] && Cedu[0] > Cedu[2] && Cedu[0] > Cedu[3] && Cedu[0] > Cedu[4])
            {
                Console.WriteLine("การศึกษาต่ำกว่าอนุปริญญา");
            }
            else if (Cedu[1] > Cedu[2] && Cedu[1] > Cedu[3] && Cedu[1] > Cedu[4])
            {
                Console.WriteLine("การศึกษาอนุปริญญา");
            }
            else if (Cedu[2] > Cedu[3] && Cedu[2] > Cedu[4])
            {
                Console.WriteLine("การศึกษาปริญญาตรี");
            }
            else if (Cedu[3] > Cedu[4])
            {
                Console.WriteLine("การศึกษาปริญญาโท");
            }
            else if (Cedu[4] > Cedu[3])
            {
                Console.WriteLine("การศึกษาปริญญาเอก");
            }
            else Console.WriteLine("ทุกระดับการศึกษาออกความเห็นเท่ากันทั้งหมด");
        }
        private void ShowHigh_Trick()
        {
            //แสดงการศึกษาที่มีคนกรอกมากที่สุดอีกสูตร ปล.เอาหาค่า max ในอารย์ไม่เวิร์คถ้าเอามาใช้แบบนี้ 
            int max = education[0];
            for (int i = 0; i < no.Length; i++)
            {
                if (max < education[i])
                {
                    max = education[i];
                }
            }
            Console.WriteLine("การศึกษาที่มีคนกรอกมาที่สุดคือระดับที่ :" + max);
        }
    }
}
