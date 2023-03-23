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
    public partial class RecordTest : Form
    {

        public RecordTest()
        {
            InitializeComponent();
            initialStudentData();
            //Console.WriteLine("Student List");
            displayStudentData();
            //StudentRecord studentData = findStudentData("00002");
            //Console.WriteLine("Data of id 00002");
            //Console.WriteLine("\t" + studentData.id + ", " + studentData.name + ", " + studentData.sex);
        }

        private void initialStudentData()
        {
            setData(0, "00001", "AAA", 'F');
            setData(1, "00002", "BBB", 'F');
            setData(2, "00003", "CCC", 'M');
            setData(3, "00004", "DDD", 'F');
            setData(4, "00005", "EEE", 'M');
            setData(5, "00006", "FFF", 'M');
            setData(6, "00007", "GGG", 'M');
            setData(7, "00008", "HHH", 'F');
            setData(8, "00009", "III", 'F');
            setData(9, "00010", "JJJ", 'M');
        }

        struct StudentRecord
        {
            public String id, name;
            public char sex;
        }
        StudentRecord[] student = new StudentRecord[10];
        
        private void setData(int i, string id, string name, char sex)
        {
            student[i].id = id;
            student[i].name = name;
            student[i].sex = sex;
        }


        private void displayStudentData()
        {
            for(int i =0; i<student.Length;i++)
            {
                Console.WriteLine("\t" + student[i].id + ", " + student[i].name + ", " + student[i].sex);
            }
        }

        private StudentRecord findStudentData(string id)
        {
            StudentRecord data;
            data.id = null;
            data.name = null;
            data.sex = ' ';
            int i = -1;
            do
            {
                i++;
            } while (i < student.Length && student[i].id != id);
            if (i < student.Length)
            {
                data = student[i];
            }
            return data;
        }

        struct StudentResult
        {
            public String id2, name2;
            public char sex2;
        }

        StudentResult[] result = new StudentResult[10];

        private void setResult(int i, String id2, String name2, char sex2)
        {
            result[i].id2 = id2;
            result[i].name2 = name2;
            result[i].sex2 = sex2;
        }

        private void findStudentSex()
        {
            StudentRecord data;
            data.id = null;
            data.name = null;
            data.sex = ' ';
            int j = 0;

            for (int i = 0; i < student.Length; i++)
            {
                data = student[i];
                if (data.sex == 'F')
                {
                    setResult(j, data.id, data.name, data.sex);
                    j++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("\t" + result[i].id2 + ", " + result[i].name2 + ", " + result[i].sex2);
            }
        }

    }
}