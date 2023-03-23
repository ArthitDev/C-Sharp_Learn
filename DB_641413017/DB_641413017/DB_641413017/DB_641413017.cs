using System.Windows.Forms;

namespace DB_641413017
{
    public partial class DB_641413017 : Form
    {
        public DB_641413017()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close ? ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
        //ปุ่ม New สำหรับเคีลยร์ฟอร์มเพื่อกรอกค่าใหม่
        private void NEW_Click(object sender, EventArgs e)
        {
            id_number.Clear(); //ช่อง ID
            stud_name.Clear(); // ช่อง NAME
            major.SelectedIndex = -1;
            F.Checked = false; //ช่องเช็คเพศหญิง
            M.Checked = false; //ช่องเช็คเพศชาย
            None.Checked = false; //ช่องไม่ระบุเพศ
            sp_1.Checked = false; // ช่องความสามารถพิเศษ
            sp_2.Checked = false; //       ''
            sp_3.Checked = false; //       ''
            sp_4.Checked = false; //       ''
            sp_5.Checked = false; //       '' 
            sp_6.Checked = false; //       ''
            sp_7.Checked = false;
        }
        //ปุ่ม Display สำหรับโชว์ค่าทั้งหมดที่กรอก
        private void DISPLAY_Click(object sender, EventArgs e)
        {
            //เช็ค TextBox ของ ID,Name และ RadioButton ของเพศ
            string ms = ""; // กำหนดตัวแปลสำหรับเก็บข้อความ
            ms = "รหัส : " + id_number.Text + "\n" + "ชื่อ : " + stud_name.Text + "\n"; //นำ ID , ชื่อ มาแสดง
            if (F.Checked) //ช่องเพศหญิง
            {
                ms += "เพศ : " + "Female" + "\n" + "สาขาวิชา : " + major.Text + "\n"; //นำ ID , ชื่อ + สาขา มาแสดง
            }
            else if (M.Checked) //ช่องเพศหญิง
            {
                ms += "เพศ : " + "Male" + "\n" + "สาขาวิชา : " + major.Text + "\n"; //นำ ID , ชื่อ + สาขา มาแสดง 
            }
            else if (None.Checked)//ช่องไม่ระบุเพศ
            {
                ms += "เพศ : " + "ไม่ระบุ" + "\n" + "สาขาวิชา : " + major.Text + "\n"; //นำ ID , ชื่อ + สาขา มาแสดง
            }
            if (sp_1.Checked) // ช่องความสามารถพิเศษ 1
            {
                ms += "ความสามารถพิเศษ : " + sp_1.Text + "\n";
            }
            if (sp_2.Checked) // ช่องความสามารถพิเศษ 2
            {
                ms += "ความสามารถพิเศษ : " + sp_2.Text + "\n";
            }
            if (sp_3.Checked) // ช่องความสามารถพิเศษ 3
            {
                ms += "ความสามารถพิเศษ : " + sp_3.Text + "\n";
            }
            if (sp_4.Checked) // ช่องความสามารถพิเศษ 4
            {
                ms += "ความสามารถพิเศษ : " + sp_4.Text + "\n";
            }
            if (sp_5.Checked) // ช่องความสามารถพิเศษ 5
            {
                ms += "ความสามารถพิเศษ : " + sp_5.Text + "\n";
            }
            if (sp_6.Checked) // ช่องความสามารถพิเศษ 6
            {
                ms += "ความสามารถพิเศษ : " + sp_6.Text + "\n";
            }
            MessageBox.Show(ms); //แสดงผลลัพธ์เป็นกล่องข้อความ
        }
        private void data_add_Click(object sender, EventArgs e)
        {
            string ms = "";
            ms = id_number.Text + "," + stud_name.Text + ",";
            if (F.Checked)
            {
                ms += "Female" + "," + major.Text + ",";
            }
            else if (M.Checked)
            {
                ms += "Male" + "," + major.Text + ",";
            }
            else if (None.Checked)
            {
                ms += "None" + "," + major.Text + ",";
            }
            ms += major.SelectedItem + ",";
            if (sp_1.Checked)
            {
                ms += sp_1.Text + ",";
            }
            if (sp_2.Checked)
            {
                ms += sp_2.Text + ",";
            }
            if (sp_3.Checked)
            {
                ms += sp_3.Text + ",";
            }
            if (sp_4.Checked)
            {
                ms += sp_4.Text + ",";
            }
            if (sp_5.Checked)
            {
                ms += sp_5.Text + ",";
            }
            if (sp_6.Checked)
            {
                ms += sp_6.Text + ",";
            }
            /*String allWords = ms;
            String[] wordsArray = allWords.Split(',');
            foreach(String word in wordsArray)
            {
                if (!stud_data.Text.Contains(word))
                {
                    stud_data.Items.Add(word);
                }
            }
            stud_data.Items.Add("------------------------------------------------------");
            ms += ms.Substring(0,ms.Length-2);*/
            stud_data.Items.Add(ms);
        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear Data ? ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                stud_data.Items.Clear();
        }
        public void sp_7_CheckedChanged(object sender, EventArgs e)
        {
            sp_1.Checked = sp_7.Checked;
            sp_2.Checked = sp_7.Checked;
            sp_3.Checked = sp_7.Checked;
            sp_4.Checked = sp_7.Checked;
            sp_5.Checked = sp_7.Checked;
            sp_6.Checked = sp_7.Checked;
        }

        private void stud_data_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {      
                    string st = stud_data.SelectedItem.ToString();
                    string[] data = st.Split(',');
                    id_number.Text = data[0].ToString();
                    stud_name.Text = data[1].ToString();
                    if (data[2] == "Female")
                    {
                        F.Checked = true;
                    }
                    else if (data[2] == "Male")
                    {
                        M.Checked = true;
                    }
                    else if (data[2] == "None")
                    {
                        None.Checked = true;
                    }
                    major.SelectedItem = data[3];

                    for (int i = 4; i < data.Length; i++)
                    {
                        switch (data[i])
                        {
                            case "เล่นดนตรี": sp_1.Checked = true; break;
                            case "ร้องเพลง": sp_2.Checked = true; break;
                            case "เล่นเกม": sp_3.Checked = true; break;
                            case "ภาษา": sp_4.Checked = true; break;
                            case "ศิลปะ": sp_5.Checked = true; break;
                            case "กีฬา": sp_6.Checked = true; break;
                            case "เลือกทั้งหมด": sp_7.Checked = true; break;
                        }
                    }
            }
            catch(Exception err)
            {
                
            }
        }
    }
}