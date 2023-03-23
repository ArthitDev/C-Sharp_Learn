using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faxionz02
{
    public partial class ArrayTest : Form
    {
        public ArrayTest()
        {
            InitializeComponent();
        }

        private String getDayName(int no)
        {
            String[] dayname = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Seturday" };
            //if (no >=1 && no <=7)
            //    return 
            try
            {
                return dayname[no - 1];
            }
            catch (Exception)
            {
                return "Unkown";
            }
            //String dayName = "";
            //switch (no)
            //{
            //    case 1: return "Sunday";
            //    case 2: return "Monday"; 
            //    case 3: return "Tuesday"; 
            //    case 4: return "Wednesday"; 
            //    case 5: return "Thursday"; 
            //    case 6: return "Friday"; 
            //    case 7: return "Seturday"; 
            //default : dayName = return "Unkown"; 
            //}
            //return "UnKown";
        }

        private String getMonthName(int month)
        {
            String[] monthname = { "january", "february", "march" , "april" , "may" , "june" , "july",
                "august","september","october","november","december"};
            try
            {
                return monthname[month - 1];
            }
            catch (Exception)
            {
                return "Unkown";
            }
            //switch(month)
            //{
            //    case 1: return "january";
            //    case 2: return "february";
            //    case 3: return "march";
            //    case 4: return "april";
            //    case 5: return "may";
            //    case 6: return "june";
            //    case 7: return "july";
            //    case 8: return "august";
            //    case 9: return "september";
            //    case 10: return "october";
            //    case 11: return "november";
            //    case 12: return "december";
            //}
            //return "UnKown";
        }

        private void shownumber(int[] number)
        {
            String ms=" ";
            for (int i = 0; i < number.Length; i++)
            {
                ms = ms + number[i]+" "; 
                if((i+1) % 20==0)
                {
                    ms = ms + "\n";
                }
            }
            MessageBox.Show(ms + "\n");
        }

        private int sumnumber(int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + number[i];
            }
            return sum;
        }

        private void averageNumber(int[] number)
        {
            //double average = 0;
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum = sum + number[i];
            //}
            int sum = sumnumber(number);
            double average = sum*1.0 / number.Length;
            Console.WriteLine(average);
            
        }

        private void countnumber(int [] number)
        {
            //int num1 = 0; int num2 = 0; int num3 = 0; int num4 = 0;int  num5 = 0; int num6 = 0;
            //int num7 = 0; int num8 = 0; int num9 = 0;
            int[] c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, };
            double cnum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int num = number[i];
                c[num - 1]++;
                //switch (number[i])
                //{
                //    case 1: c[0]++; break;
                //    case 2: c[1]++; break;
                //    case 3: c[2]++; break;
                //    case 4: c[3]++; break;
                //    case 5: c[4]++; break;
                //    case 6: c[5]++; break;
                //    case 7: c[6]++; break;
                //    case 8: c[7]++; break;
                //    case 9: c[8]++; ; break;
                    //case 1: num1 = num1 + 1; break;
                    //case 2: num2 = num2 + 1; break;
                    //case 3: num3 = num3 + 1; break;
                    //case 4: num4 = num4 + 1; break;
                    //case 5: num5 = num5 + 1; break;
                    //case 6: num6 = num6 + 1; break;
                    //case 7: num7 = num7 + 1; break;
                    //case 8: num8 = num8 + 1; break;
                    //case 9: num9 = num9 + 1; break;
                    //default: cnum =0; break;
                //}
            }
            for (int i = 0; i < c[i];i++)
            {
                Console.WriteLine(c[i]);
            }
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);
            //Console.WriteLine(num6);
            //Console.WriteLine(num7);
            //Console.WriteLine(num8);
            //Console.WriteLine(num9);

        }


        private void ArrayTest_Load(object sender, EventArgs e)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                             1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                             1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,};
            countnumber(number);
        }
    }
}
