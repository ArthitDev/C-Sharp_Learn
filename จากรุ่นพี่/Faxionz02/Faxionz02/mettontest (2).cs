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
    public partial class mettontest : Form
    {
        public mettontest()
        {
            String[] grade = { "D+", "C", "C+", "D+", "D", "C+", "C", "A" };
            int[] credit = { 3, 3, 3, 3, 3, 3, 3, 2 };
            double gpa = somputeGPA(grade, credit);
            MessageBox.Show(gpa.ToString());
        }

        private void mettontest_Load(object sender, EventArgs e)
        {
            //String[] grade = { "D+", "C", "C+", "D+", "D", "C+", "C", "A" };
            //int[] credit = { 3, 3, 3, 3, 3, 3, 3, 2 };
            //double gpa = somputeGPA(grade, credit);
            //MessageBox.Show(gpa.ToString());
            //String[] grade = { "D+", "C", "C+", "D+", "D", "C+", "C", "A" };
            //int[] credit = { 3, 3, 3, 3, 3, 3, 3 ,2};
            //somputeGPA(grade,credit);
            //somputeGPA();
        }

        private void backwardNumber(int N)
        {
            for (int i = 1; i <= N; N--)
            {
                Console.WriteLine(N);
            }
        }

        private void showOddNumber(int A, int N)
        {
            if (A % 2 == 1)
            {
                for (int i = A; i <= N; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
                A++;
            for (int i = A; i <= N; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

        private int factorial(int N)
        {
            int result = 1;
            for (int i = 1; i <= N; i++)
            {
                result = result * i;
            }
            return result;
        }

        private Boolean isEvenNumber(int num)
        {
            //Boolean result;
            {
                if (num % 2 == 0)
                    return true;
                //result = true;
                else
                    return false;
                    //result = false;
                //return result;
            }
        }

        private double getGradeValue(string grade)
        {
            //double score=0;
            switch (grade)
            {
                case "A": return  4; 
                case "B+": return  3.5; 
                case "B": return  3; 
                case "C+": return  2.5; 
                case "C": return  2; 
                case "D+": return  1.5; 
                case "D": return  1; 
                case "F": return  0; 
            }
            return 0;
            //if (gade == 4)
            //    Console.WriteLine("A");
            //else
            //    if (gade <= 3.5)
            //    Console.WriteLine("B+");
            //else
            //    if (gade <= 3)
            //    Console.WriteLine("B");
            //else
            //    if (gade <= 2.5)
            //    Console.WriteLine("C+");
            //else
            //    if (gade <= 2)
            //    Console.WriteLine("C");
            //else
            //    if (gade <= 1.5)
            //    Console.WriteLine("D+");
            //else
            //    if (gade <= 1)
            //    Console.WriteLine("D");
            //else
            //    if (gade >= 0)
            //    Console.WriteLine("F");
        }

        private void arrayDemo()
        {
            String[] gade = new String[40];
            Char[] sex = new Char[40];
            gade[0] = "A";
            sex[0] = 'M';
            //int[] number = new int[10];
            //number[0] = 0;
            //number[1] = 9;
            //number[2] = 9;
            //number[3] = 6;
            //number[4] = 2;
            //number[5] = 9;
            //number[6] = 5;
            //number[7] = 1;
            //number[8] = 8;
            //number[9] = 2;
            //int[] number = {0,9,9,6,2,9,5,1,8,2 };
            //string ms = "";
            //for (int i =0; i<number.Length;i++)
            //{
            //    Console.WriteLine(number[i]);
            //    ms = ms + number[i];
            //}
            //MessageBox.Show(ms);
            //Console.Write(number[0] + number[1] + number[2] + number[3] + number[4] + number[5] + number[6]);
        }

        private double somputeGPA(String[] grade, int[] credit)
        {
            //String[] grade = { "D+", "C", "C+","D+", "D", "C+", "C","A" };
            //int[] credit = { 3, 3, 3, 3, 3, 3, 3 ,2};
            double sum = 0;
            int sumCredit = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                double b = getGradeValue(grade[i]);
                double result = b * 3;
                sum = sum + result;
                sumCredit = sumCredit + credit[i];
            }
            double gpa = sum / sumCredit;
            return gpa;
        }
    }
}
