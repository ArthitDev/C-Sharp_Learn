using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Grade
{
    public partial class ListStructure : Form
    {
        List<string> All_Data = new List<string>();
        public ListStructure()
        {
            InitializeComponent();
        }
        private void Name_box_TextChanged(object sender, EventArgs e) //ช่องชื่อ
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Name_box.Text, "^[a-zA-Z ก-ฮ ะั็าิ่ํุูเใไโอยวฤฤๅฦฦๅ]"))
            {
                    Name_box.Clear();
            }
            else
            {
                Name_box.ForeColor = Color.Black;
            }
        }
        private void Phone_box_TextChanged(object sender, EventArgs e) //ช่องเบอร์โทร
        {
            if (Phone_box.TextLength == 10 && (!System.Text.RegularExpressions.Regex.IsMatch(Name_box.Text, "^[0-9]")))
            {
                Phone_box.ForeColor = Color.Black;
            }
            else
            {
                Phone_box.ForeColor = Color.Red;
            }    
        }
        private void Add_Button_Click(object sender, EventArgs e) //ปุ่ม Add
        {
            bool Check = true;
            All_Data.Add(Name_box.Text);
            All_Data.Add(Phone_box.Text);
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
            if (Check == true)
            {
                Name_box.Clear();
            }             
        }
        private void Phone_Start_End_Click(object sender, EventArgs e)//ปุ่มแสดงเบอร์แรกถึงเบอร์สุดท้าย
        {
            int count = 0;
            string show_all_Data = "";
            foreach (string Data in All_Data)
            {
                show_all_Data += Data + "\t";
                count++;
                if(count % 2 == 0)
                {
                    show_all_Data += "\n";
                }
            }
            MessageBox.Show(show_all_Data);
        }
        private void Phone_End_Start_Click(object sender, EventArgs e)//ปุ่มแสดงเบอร์สุดท้ายถึงเบอร์แรก
        {
            List<string> NumPhone_Data = new List<string>(); 
            foreach (string Data in All_Data)
            {
                NumPhone_Data.Add(Data);
            }
            NumPhone_Data.Reverse();
            string show_all_Data = "";
            int Check = 0;
            foreach (string Data in NumPhone_Data)
            {
                show_all_Data += Data + "\t";
                Check++;
                if (Check % 2 == 0)
                {
                    show_all_Data += "\n";
                }
            }
            MessageBox.Show(show_all_Data);
            NumPhone_Data.Reverse();
        }
        private void Phone_Sort_No_Click(object sender, EventArgs e)//ปุ่มแสดงเบอร์โทรแบบเรียงลำดับ
        {
            List <string> NumPhone_Data = new List<string>();
            int Check = 0;
            foreach (string Data in All_Data)
            {
                if (Check % 2 != 0)
                {
                    NumPhone_Data.Add(Data);
                    Check++;
                }
                else
                {
                    Check++;
                }
            }
            NumPhone_Data.Sort();
            string Show_Data = "";
            foreach (string Data in NumPhone_Data)
            {
                int index = All_Data.IndexOf(Data);
                Show_Data += All_Data[index - 1] + "\t" + Data;
                if (index % 2 != 0)
                {
                    Show_Data += "\n";
                }
            }
            MessageBox.Show(Show_Data);
        }
        private void Search_By_Name_Click(object sender, EventArgs e)//ปุ่มค้นหาเบอร์โทรตามชื่อ
        {
            string Name_Find = Name_box.Text;
            foreach(string Data in All_Data)
            {
                if (Name_Find == Data)
                {
                    int Index = All_Data.IndexOf(Data);
                    Phone_box.Text = All_Data[Index + 1];
                }
            }
        }
        private void Delete_Phone_Click(object sender, EventArgs e)//ปุ่มลบเบอร์โทรศัพท์
        {
            string Phone_Delete = Phone_box.Text;
            foreach (string Data in All_Data)
            {
                int Index = All_Data.IndexOf(Data);
                if (Phone_Delete == Data)
                {
                    All_Data.RemoveAt(Index);
                }
            }
        }
        private void Clear_Button_Click(object sender, EventArgs e)//ปุ่มเคลียร์ข้อมูล
        {
            DialogResult dr = MessageBox.Show("ต้องการลบข้อมูลทั้งหมดหรือไม่ ? ", "ยืนยันจะลยข้อมูล", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                All_Data.Clear();
                All_Data.Clear();
            }
        }
        private void End_Program_Click(object sender, EventArgs e)//ปุ่มจบการทำงาน
        {
            DialogResult dr = MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่ ? ", "ยืนยัน", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void show_num_set_Click(object sender, EventArgs e)//แสดงเบอร์แบบเรียงลำดับเบอร์
        {
            /*int abc = 0;
            do
            {
                List<string> numphone = new List<string>();
                int x = 0;
                foreach (string i in input_name_numphone)
                {
                    if (x % 2 != 0)
                    {
                        numphone.Add(i);
                        x++;
                    }
                    else { x++; }

                }
                numphone.Sort();
                string data = "";
                foreach (string i in numphone)
                {
                    int location = input_name_numphone.IndexOf(i);
                    data += input_name_numphone[location - 1] + "\t" + i;
                    if (location % 2 != 0)
                    {
                        data += "\n";
                    }
                }
                MessageBox.Show(data);
                abc = input_name_numphone.Count;
            } while (abc != input_name_numphone.Count);*/
        }
    }
}


