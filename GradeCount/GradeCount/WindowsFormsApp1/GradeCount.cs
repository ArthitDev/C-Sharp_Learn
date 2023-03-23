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
    public partial class GradeCount : Form
    {
        char[] grade = {'A','B','C','D','F','A','B','C','D','F', 'A', 'B', 'C', 'D', 'F', 'A', 'B', 'C', 'D', 'F',
                        'A','B','C','D','F','A','B','C','D','F', 'A', 'B', 'C', 'D', 'F', 'A', 'B', 'C', 'D', 'F',
                        'A','B','C','D','F','A','B','C','D','F', 'A', 'B', 'C', 'D', 'F', 'A', 'B', 'C', 'D', 'F',
                        'A','B','C','D','F','A','B','C','D','F', 'A', 'B', 'C', 'D', 'F', 'A', 'B', 'C', 'D', 'F',
                        'A','B','C','D','F','A','B','C','D','F', 'A', 'B', 'C', 'D', 'F', 'A', 'B', 'C', 'D', 'F',
                        'F','C','A','C','A','A'};
        public GradeCount()
        {
            InitializeComponent();
            GradeCheck();
        }
        private void GradeCheck()
        {
            //แสดงเกรดทั้งหมด
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine("เกรด : " + grade[i]);
            }
            //นับจำนวนแยกตามเกรด
            int A = 0, B = 0, C = 0, D = 0, F = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                switch (grade[i])
                {
                    case 'A': A++; break;
                    case 'B': B++; break;
                    case 'C': C++; break;
                    case 'D': D++; break;
                    case 'F': F++; break;
                }
            }
            Console.WriteLine("รวมเกรด A  = " + A);
            Console.WriteLine("รวมเกรด B  = " + B);
            Console.WriteLine("รวมเกรด C  = " + C);
            Console.WriteLine("รวมเกรด D  = " + D);
            Console.WriteLine("รวมเกรด F  = " + F);
            //เกรดที่มากที่สุด
            if (A > B && A > C && A > D && A > C && A > F)
            {
                Console.WriteLine("เกรด A มากที่สุด");
            }
            else if (B > C && B > D && B > F)
            {
                Console.WriteLine("เกรด B มากที่สุด = " + B);
            }
            else if (C > D && C > F)
            {
                Console.WriteLine("เกรด C มากที่สุด = " + C);
            }
            else if (D > F)
            {
                Console.WriteLine("เกรด D มากที่สุด = " + D);
            }
            else
                Console.WriteLine("เกรด F มากที่สุด = " + F);
        }
        private void countGrade()
        {
            char[] gradeList = { 'A', 'B', 'C', 'D', 'F' };
            int[] count = { 0, 0, 0, 0, 0 };
            //นับจำนวนแยกตามเกรดแบบใช้รหัส AsCII 
            for (int i = 0; i < grade.Length; i++)
            {
                int asc = grade[i] - 65;
                if (asc == 5)
                {
                    asc = 4;
                }
                count[asc]++;

            }
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(gradeList[i] + "=" + count[i]);
            }
        }
        private void getMax()
        {
            //หาเกรดที่มีจำนวนคนได้มากที่สุดอีกแบบ
            char[] gradeList = { 'A', 'B', 'C', 'D', 'F' };
            int[] count = { 0, 0, 0, 0, 0 };
            int max = count[0];
            char maxGrade = gradeList[0];
            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] > max)
                {
                    max = count[i];
                    maxGrade = gradeList[i];
                }
            }
            Console.WriteLine("เกรดที่มีคนได้มากที่สุด : " + maxGrade);
        }
    }
}