using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class MultiDimensionArray : Form
    {
        //int[] major = { 13, 63, 94 };
        //string[,] student = { { "IT1", "IT2", "IT3", "IT4", "IT5" }, { "CS1", "CS2", "CS3", "CS4", "CS5" }, { "BC1", "BC2", "BC3", "BC4", "BC5" } };

        int[,] A = { {1,2,3,4 }, {4,2,6,7 }, {4,1,8,5 } };
        int[,] B = { {6,7,8,9 }, {1,2,3,4 }, {5,6,7,8 } };
        int[,] C = new int[3, 4];
        public MultiDimensionArray()
        {
            InitializeComponent();
            piusMatrix();
        }
        //private void showStudent()
        //{
        //    Console.WriteLine(student.Length);
        //    Console.WriteLine(student.GetLength(0));
        //    Console.WriteLine(student.GetLength(1));

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine(major[i]);
        //        for (int j = 0; j < 5; j++)
        //        {
        //            Console.WriteLine(student[i, j] + " ");
        //        }
        //        Console.WriteLine("----");
        //    }
        //}

        //private void showA()
        //{
        //    Console.WriteLine(" A ");
        //    for (int i = 0; i < A.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < A.GetLength(1); j++)
        //        {

        //        }
        //    }
        //}

        //private void showB()
        //{
        //    Console.WriteLine(" B ");
        //    for (int i = 0; i < B.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < B.GetLength(1); j++)
        //        {

        //        }
        //    }
        //}

        private void showC()
        {
            Console.WriteLine(" C ");
            for (int i = 0; i < C.GetLength(0); i++)
            {

                for (int j = 0; j < C.GetLength(1); j++)
                {

                }

            }
        }

        private void showData(int[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.WriteLine(data[i, j] + " ");
                }
                Console.WriteLine("----");
            }
        }

        private void piusMatrix()
        {

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i,j] + B[i,j];
                    Console.WriteLine(C[i, j] + " ");
                }
                Console.WriteLine("----");
            }
        }

        private void rrr()
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
                Console.WriteLine("----");
            }
        }

        private void mmm()
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] * B[i, j];
                }
                Console.WriteLine("----");
            }
        }

    }
}
