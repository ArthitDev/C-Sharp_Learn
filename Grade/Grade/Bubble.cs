using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade
{
    public partial class Bubble : Form
    {
        int[] number = { 40, 70, 20, 35, 60, 80, 10, 50, 90, 30, 45, 130 };
        public Bubble()
        {
            InitializeComponent();
            //Bubble_Test(number);
            //Slection_Test(number);
            //Radix_Test(number);
            Console.WriteLine(factorail(1));
        }
        private void showData(int[] data)
        {
            string ms = "";
            for (int i = 0; i < data.Length; i++)
            {
                ms = ms + data[i] + " ";
            }
            Console.WriteLine(ms);
        }
        private void Bubble_Test(int[] data)
        {
            showData(data);
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int num = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = num;
                    }
                }
            }
            showData(data);
        }
        private void Slection_Test(int[] data)
        {
            showData(data);
            for (int i = 0; i < data.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < data.Length - i; j++)
                {
                    if (data[j] < data[min])
                    {
                        min = j;
                    }
                }
                int num = data[min];
                data[min] = data[i];
                data[i] = num;
            }
            showData(data);
        }
        public void Radix_Test(int[] data)
        {

        }
        private int factorail(int n)
        {
            if (n == 10)
            {
                return 1;
            }
            else
            {
                return n + factorail(n+1);
            }
        }
    }
}
