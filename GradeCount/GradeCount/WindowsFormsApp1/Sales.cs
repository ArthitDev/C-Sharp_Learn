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
    public partial class Sales : Form
    {
        int[] no = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 };
        int[] year = { 2562, 2562, 2562, 2562, 2562, 2562, 2562, 2562, 2562, 2562, 2562, 2562,
                       2563, 2563, 2563, 2563, 2563, 2563, 2563, 2563, 2563, 2563, 2563, 2563,
                       2564, 2564, 2564, 2564, 2564, 2564, 2564, 2564, 2564};
        int[] month ={1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                      1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] sales = {5000,20000,4000,6000,10000,10000,50000,30000,9999,7000,3000,5000,4000,25000,8900,7800,4000,5000,45000,9000,8000,7000,9000,6000,3000,65000,
                       75000,80000,100000,60000,70000,90000,60000};
        public Sales()
        {
            InitializeComponent();
            //ShowAll();
            //ShowSales_2562();
            //ShowSale_2563_Up50K();
            //CountSales_Up50K();
            //SumSales_All();
            //AvgSales_All();
            //SumSales_Year();
            //AvgSales_AnyYear();
            Year_2563_HighMonth();
            MonthHigh_YearHigh();

        }
        private void ShowAll()
        {
            //1.แสดงยอดขายทั้งหมด
            for (int i = 0; i < no.Length; i++)
            {
                Console.WriteLine("ยอดการขายลำดับที่." + no[i] + " : " + sales[i]);
            }
        }
        private void ShowSales_2562()
        {
            //2.แสดงยอดขาย ปี 2562 
            for (int i = 0; i < no.Length; i++)
            {
                if (year[i] == 2562)
                {
                    Console.WriteLine("ยอดขายปี 2562 : " + sales[i] + " บาท");
                }
            }
        }
        private void ShowSale_2563_Up50K()
        {
            //3.แสดงยอดขายปี 2563 ตั้งแต่ 50K ขึ้นไป
            for (int i = 0; i < no.Length; i++)
            {
                if (year[i] == 2563 && sales[i] >= 50000)
                {
                    Console.WriteLine("ยอดขายปี 2563 ที่มากกว่า 50000 บาท : " + sales[i]);
                }
                else
                {
                    Console.WriteLine("ยอดขายปี 2563 ไม่มีมากกว่า 50000 บาท "); break;
                }
            }
        }
        private void CountSales_Up50K()
        {
            //4.นับจำนวนเดือนที่มียอดขายเกิน 50K
            int Cmonth_50K = 0;
            for (int i = 0; i < no.Length; i++)
            {
                if(sales[i] >= 50000)
                {
                    Cmonth_50K++;
                }
            }
                Console.WriteLine("จำนวนเดือนที่มียอดขายเกิน 50K มี : " + Cmonth_50K + " เดือน");
        }
        private void SumSales_All()
        {
            //5.รวมยอดขายทั้งหมด
            int SumSales = 0;
            for(int i = 0; i < no.Length; i++)
            {
                SumSales = SumSales + sales[i];
            }
            Console.WriteLine("ยอดขายรวมทั้งหมด : "+SumSales);
        }
        private void AvgSales_All()
        {
            //6.หาค่าเฉลี่ยของยอดขายทั้งหมด
            double SumSales = 0;
            for (int i = 0; i < no.Length; i++)
            {
                SumSales = SumSales + sales[i];
            }
             SumSales = SumSales * 1.0 / no.Length;
            Console.WriteLine("ยอดขายเฉลี่ยทั้งหมด : " +SumSales + " บาท");
        }
        private void SumSales_Year()
        {
            //7.รวมยอดขายแยกตามปี
            int[] SumSales = { 0, 0, 0 };
            for(int i = 0; i < no.Length; i++)
            {
                switch (year[i])
                {
                    case 2562: SumSales[0] = SumSales[0] + sales[i]++; break;
                    case 2563: SumSales[1] = SumSales[1] + sales[i]++; break;
                    case 2564: SumSales[2] = SumSales[2] + sales[i]++; break;
                }
            }
            Console.WriteLine("ยอดขายปี 2562 : " + SumSales[0] + " บาท");
            Console.WriteLine("ยอดขายปี 2563 : " + SumSales[1] + " บาท");
            Console.WriteLine("ยอดขายปี 2564 : " + SumSales[2] + " บาท");
        }
        private void AvgSales_AnyYear()
        {
            //8.หาค่าเฉลี่ยของยอดขายแต่ละปี ยอดขาย / 12 ยกเว้นปี 2564 ยอดขาย / 9 
            int[] SumSales = { 0, 0, 0 };
            double[] AvgSales = { 0, 0, 0 };
                for (int i = 0; i < no.Length; i++)
                {
                    switch (year[i])
                    {
                        case 2562: SumSales[0] = SumSales[0] + sales[i]++; break;
                        case 2563: SumSales[1] = SumSales[1] + sales[i]++; break;
                        case 2564: SumSales[2] = SumSales[2] + sales[i]++; break;
                    }
                }
            AvgSales[0] = SumSales[0] * 1.0 / 12;
            AvgSales[1] = SumSales[1] * 1.0 / 12;
            AvgSales[2] = SumSales[2] * 1.0 / 9;
            Console.WriteLine("ยอดขายเฉลี่ยปี 2562 : " + AvgSales[0] + " บาท");
            Console.WriteLine("ยอดขายเฉลี่ยปี 2563 : " + AvgSales[1] + " บาท");
            Console.WriteLine("ยอดขายเฉลี่ยปี 2564 : " + AvgSales[2] + " บาท");
        }
        private void Year_2563_HighMonth()
        {
            //9.ปี 2563 เดือนไหนมียอดขายสูงที่สุด
            string[] Mlist = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int Max = sales[0];
            string MaxMonth = Mlist[0];
            for(int i = 0; i < no.Length; i++)
            {
                if(year[i] == 2563)
                {
                    if (sales[i] > Max)
                    {
                        Max = sales[i];
                        MaxMonth = Mlist[i];
                    }
                }
            }
            Console.WriteLine("เดือนที่มียอดขายสูงสุดคือเดือน : " + MaxMonth + " เป็นจำนวนเงิน : " + Max + " บาท");
        }
        private void MonthHigh_YearHigh()
        {
            //10.เดือนที่มียอดขายสูงสุด ? และ เป็นของปีไหน ?
            string[] Monthlist = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int Max = sales[0];
            int MaxYear = 0;
            string MaxMonth = Monthlist[0];
            for (int i = 0; i < no.Length; i++)
            {
                    if (sales[i] > Max)
                    {
                        Max = sales[i];
                        MaxMonth = Monthlist[i];
                        MaxYear = year[i];
                    }
            }
            Console.WriteLine("เดือนที่มียอดขายสูงสุดคือเดือน : " + MaxMonth + " และเป็นของปี : " + MaxYear + " เป็นจำนวนเงิน : " + Max + " บาท");
        }
          
    }
}
