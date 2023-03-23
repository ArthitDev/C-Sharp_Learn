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
    public partial class RecheckAlgorithm : Form
    {
        Random Frandom = new Random();
        public RecheckAlgorithm()
        {
            InitializeComponent();
        }

        private void RecheckAlgorithm_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(getSexName("F"));
            //int[] ages = { 1, 5, 68, 7, 45, 12, 65, 44, 51, 15, 3, 55, 48, 2, 56, };
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(initialNumber(10)[i]);
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(initialOperator()[i]);
            //}
            //int[] num1 = initialNumber(10);
            //int[] num2 = initialNumber(10);
            //for(int i = 1; i < 10;i++)
            //{
            //    Console.WriteLine(showQuestion(num1, initialOperator(), num2)[i]);
            //}
            displayString(2,"Faxionz");
        }

        private Boolean isOddNumber(int number)
        {
            if (number % 2 == 1)
                return true;
            else
                return false;
        }

        private String getSexName(String sex)
        {
            String sexname = "";
            if (sex.ToUpper() == "F")
            {
                sexname = sexname + "Female";
            }
            else
                if (sex.ToUpper() == "M")
            {
                sexname = sexname + "Male";
            }
            return sexname;
        }

        private int valueOfOperator(char opt)
        {
            int value = 0;
            switch (opt)
            {
                case '+': case '-': value = +1; break;
                case '*': case '/': value = +2; break;
                case '^': value = +3; break;
            }
            return value;
        }

        private String majorName(int pass)
        {
            string m_name = "";
            switch (pass)
            {
                case 13: m_name = "Information Technology"; break;
                case 63: m_name = "Computer Science"; break;
                case 68: m_name = "Graphic Design"; break;
                case 94: m_name = "Business Computer"; break;
                case 98: m_name = "Computer Engineering"; break;
            }
            return m_name;
        }

        private String bachelorDegreeName(int pass)
        {
            String ect = "";
            switch (pass)
            {
                case 2: ect = "ครุศาสตรบัณฑิต"; break;
                case 4: ect = "วิทยาศาสตรบัณฑิต"; break;
                case 7: ect = "ศิลปศาสตรบัณฑิต"; break;
                case 9: ect = "วิศวกรรมศาสตรบัณฑิต"; break;
            }
            return ect;
        }

        private void showEvenNumber(int a, int n)
        {
            if (a % 2 == 1)
                a++;
            for (int i = a; i <= n; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

        private void showOddNumber(int a, int n)
        {
            if (a % 2 == 0)
                a++;
            for (int i = a; i <= n; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }

        private void forwardShow(String txt)
        {
            String tx = "";
            for (int i = 0; i < txt.Length; i++)
            {
                tx = txt.Substring(i, 1);
                Console.WriteLine(tx);
            }
        }

        private void backwardShow(String txt)
        {
            String tx = "";
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                tx = txt.Substring(i,1);
                Console.WriteLine(tx);
            }

        }

        private void displayString(int num, String txt)
        {
            String tx = "";
            if (num == 1)
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    tx = txt.Substring(i, 1);
                    Console.WriteLine(tx);
                }
            }
            else
            {
                for (int i = txt.Length - 1; i >= 0; i--)
                {
                    tx = txt.Substring(i, 1);
                    Console.WriteLine(tx);
                }
            }
        }

        private int[] countPeople(int[] age)
        {
            int[] sum = new int[7];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = 0;
            }
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] >= 60)
                {
                    sum[6] += 1;
                }
                else if (age[i] >= 50)
                {
                    sum[5] += 1;
                }
                else if (age[i] >= 40)
                {
                    sum[4] += 1;
                }
                else if (age[i] >= 30)
                {
                    sum[3] += 1;
                }
                else if (age[i] >= 20)
                {
                    sum[2] += 1;
                }
                else if (age[i] >= 10)
                {
                    sum[1] += 1;
                }
                else
                {
                    sum[0] += 1;
                }
            }
            return sum;
        }

        private int[] initialNumber(int n)
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = Frandom.Next(1, n);
            }
            return num;
        }

        private String randomOperator(int startIndex, int endIndex)
        {
            int num = Frandom.Next(startIndex, endIndex);
            switch (num)
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "*";
                case 4: return "/";
                default: return "ไม่รู้";
            }

        }

        private String[] initialOperator()
        {
            String[] opt = new string[10];
            for (int i = 0; i < 10; i++)
            {
                opt[i] = randomOperator(1, 5);
            }
            return opt;
        }

        private double computeNumber(int num1, String opt, int num2 )
        {
            switch (opt)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/": return num1 / num2;
                default: return 0;
            }
        }

        private String[] showQuestion(int[] num1, String[] opt, int[] num2)
        {
            String[] st = new String[10];
            for(int i = 0;i <10; i++)
            {
                st[i] += num1[i].ToString() + opt[i].ToString() + num2[i].ToString() + "=" + computeNumber(num1[i], opt[i].ToString(), num2[i] );
            }
            return st;
        }

        private String evaluate(int score)
        {
            if (score >= 9)
            {
                return "ดีมาก";
            }
            else if (score >= 7)
            {
                return "ดี";
            }
            else if (score >= 5)
            {
                return "พอใช้";
            }
            else
                return "พยายามต่อไป";
        }

        private void checking()
        {

        }
    }
}
