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
    public partial class SubprogramTest : Form
    {
        public SubprogramTest() //ส่วนเรียกใช้เม็ดตอด
        {
            InitializeComponent();
            //PlusNumber();
            //int ans = plusNumber2();
            //showNumber();
            //Console.WriteLine(ans);
            //Console.WriteLine(sumNumber2());
            //Console.WriteLine(sumNumber(10));
            //int ans = plusNumber2(100, 100); //pass by value การส่งค่า
            //Console.WriteLine(plusNumber2(100,200));
            //แสดงผล 2 เท่าของผลบวก 100 กับ 200 
            //int ans = plusNumber2(100, 200);
            //Console.WriteLine(doubleNumber(ans)); //ไม่แนะนำ
            //Console.WriteLine(ans * 2);
            //int ans = sumNumber(5);
            //Console.WriteLine(ans);
            //showNumber(100);
            //สามารถใส่พารามิเตอร์ในเม็ดตอดได้เสมอแม้ว่าจะคืนค่าหรือไม่คืนค่า
            //โจทย์ สร้างเม็ดตอดคำนวณตัวเลข 2 จำนวนตามเครื่องหมาย
            //โจทย์ หาชื่อวัน 
            //private String getDayName (ind d) //1 = วันจันทร์ - 7
            //double ans = Compute_num(100, 200, '/');
            //Console.WriteLine(ans);
            //โจทย์แสดงสูตรคูนแม่ n ไม่คืนค่า
            //private void multiplicationTable(int n)
            //string day = getDayName(1);    //วัน
            //Console.WriteLine(day);        //วัน    
            //multiplicationTable(12);       //สูตรคูณ
            //string DayName = TestError(7); //ดัก Error
            //Console.WriteLine(DayName);  //ดัก Error
            //ShowEvenNumber(10);          //แสดงเลขคู่ 1 - N
            //int ans = sumNumber(10); //บวกเลข 1 - N
            //Console.WriteLine(ans);  //บวกเลข 1 - N
            //int ans = SumNumber_2(100, 100); //บวกเลข A-N
            //Console.WriteLine(ans);  //บวกเลข A-N
            //double ans = AvgNumber(10); // ค่าเฉลี่ย 1 -n
            //Console.WriteLine(ans);  // ค่าเฉลี่ย 1 - n
            //ShowName(10);
            //double ans = AvgNumber_2(3,6); // ค่าเฉลี่ย a-n
            //Console.WriteLine(ans); // ค่าเฉลี่ย a - n 
            //Console.WriteLine(Power(1, 3));
            







        }
        private void ShowText() //โปรแกรมย่อย,ฟังค์ชั่น,เม็ดตอด,โพรซิเยอร์
        {
            Console.WriteLine("Test");
        }
        private int doubleNumber(int x) //ไม่แนะนำ
        {
            return x * 2;
        }
        private void PlusNumber() //แบบไม่คืนค่า
        {
            int x = 100, y = 100;
            int z = x + y;
            Console.WriteLine(z);
        }
        private int plusNumber2(int x, int y)//แบบคืนค่า //ในวงเล็บเรียกว่าพารามิเตอร์
        {
            //int x = 100, y = 100;
            //int z = x + y;
            //console.WriteLine(z);
            return x + y;
        }
        private int sumNumber_1_1(int n)//แบบคืนค่า บวกเลข 1 - 10 
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        private int sumNumber2()//แบบคืนค่าไม่ใช้พารามิเตอร์ บวกเลข 1 - 10 
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        //แสดงเลข 1-10
        private void showNumber__1(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        private double Compute_num(int x, int y, char opt) //บวกลบคูณหารตามตัวดำเนินการคณิตศาสตร์ 
        {
            double number = 0.0;
            switch (opt)
            {
                case '+': number = x + y; break;
                case '-': number = x - y; break;
                case '*': number = x * y; break;
                case '/': number = x / y; break;
            }
            return number;
        }
        private String getDayName(int d) //แสดงวันตามเลข
        {
            switch (d)
            {
                case 1: return "วันจันทร์";
                case 2: return "วันอังคาร";
                case 3: return "วันพุทธ";
                case 4: return "วันพฤหัสบดี";
                case 5: return "วันศุกร์";
                case 6: return "วันเสาร์";
                case 7: return "วันอาทิตย์";
            }
            return "0";
        }
        private String getDayName2(int d) //แสดงวันตามเลข
        {
            string[] DayName = { "วันจันทร์", "วันอังคาร", "วันพุทธ", "วันพฤหัสบดี", "วันศุกร์", "วันเสาร์", "วันอาทิตย์"};
            if(d >= 1 && d <=7)
            {
                return DayName[d - 1];
            }
            else
            {
                return "Unknow";
            }           
        }
        private void multiplicationTable(int n) 
        {
            int MultiNum = 0;
            for(int i = 1;  i <= 12; i++)
            {
                MultiNum = n * i;
                Console.WriteLine(n + "\tX\t" + i + "\t"+ "=\t" + MultiNum);
            }            
        }
        private String TestError(int d) //แสดงวันตามเลขแบบดักจับ Error
        {
            string[] DayName = { "วันจันทร์", "วันอังคาร", "วันพุทธ", "วันพฤหัสบดี", "วันศุกร์", "วันเสาร์", "วันอาทิตย์" };
            try 
            {
                return DayName[d - 1];
            }
            catch (Exception ErrorLog)
            {
                Console.WriteLine(ErrorLog.Message);
                return "Unknow";
            }
        }
        private void ShowEvenNumber(int n)
        {
            for(int i = 2; i <= n; i+=2)
            {
                Console.WriteLine(i);
            }
        }
        private int SumNumber_1(int n)
        {
            int SumNum = 0;
            for(int i = 1; i <=n; i++)
            {
                SumNum = SumNum + i;
            }
            return SumNum;
        }
        private int SumNumber_2(int a, int n)
        {
            int SumNumber = 0;
            for(int i = a; i <=n; i++)
            {
                SumNumber = SumNumber + i;
            }
            return SumNumber;
        }
        private Double AvgNumber(int n) //ค่าเฉลี่ย 1 - n
        {
            int SumNum = 0;
            for (int i = 1; i <= n; i++)
            {
                SumNum = SumNum + i;
            }
            return SumNum * 1.0 / n;
        }
        private Double AvgNumber_2(int a, int n) //ค่าเฉลี่ย a - n
        {
            int avg = n - a + 1;
            int sum = SumNumber_2(a,n);
            return sum * 1.0 / avg;
            
        }
        private void ShowName(int n) //แสดงชื่อนักศึกษา n ครั้ง 
        {
            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine("อาทิตย์ ลุงหยะ");
            }
        }
        private int Power(int x,int y) //ค่าของ x กำลัง y
        {
            {
                return x + y;
            }
        }
        private void isEvenNumber() //ตรวจสอบเลขคู่ True/Flase
        {

        }
        private void getLengthNumber() //หาจำนวนหลักตามความยาวของตัวเลข
        {

        }
        private void toBinaly() //แปลงเลขฐาน 10 ไป ฐาน 2 
        {

        }
    }
}
