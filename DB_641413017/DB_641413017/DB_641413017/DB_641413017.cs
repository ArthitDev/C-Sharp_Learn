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
        //���� New ����Ѻ�������������͡�͡�������
        private void NEW_Click(object sender, EventArgs e)
        {
            id_number.Clear(); //��ͧ ID
            stud_name.Clear(); // ��ͧ NAME
            major.SelectedIndex = -1;
            F.Checked = false; //��ͧ����˭ԧ
            M.Checked = false; //��ͧ���Ȫ��
            None.Checked = false; //��ͧ����к���
            sp_1.Checked = false; // ��ͧ��������ö�����
            sp_2.Checked = false; //       ''
            sp_3.Checked = false; //       ''
            sp_4.Checked = false; //       ''
            sp_5.Checked = false; //       '' 
            sp_6.Checked = false; //       ''
            sp_7.Checked = false;
        }
        //���� Display ����Ѻ����ҷ���������͡
        private void DISPLAY_Click(object sender, EventArgs e)
        {
            //�� TextBox �ͧ ID,Name ��� RadioButton �ͧ��
            string ms = ""; // ��˹����������Ѻ�红�ͤ���
            ms = "���� : " + id_number.Text + "\n" + "���� : " + stud_name.Text + "\n"; //�� ID , ���� ���ʴ�
            if (F.Checked) //��ͧ��˭ԧ
            {
                ms += "�� : " + "Female" + "\n" + "�Ң��Ԫ� : " + major.Text + "\n"; //�� ID , ���� + �Ң� ���ʴ�
            }
            else if (M.Checked) //��ͧ��˭ԧ
            {
                ms += "�� : " + "Male" + "\n" + "�Ң��Ԫ� : " + major.Text + "\n"; //�� ID , ���� + �Ң� ���ʴ� 
            }
            else if (None.Checked)//��ͧ����к���
            {
                ms += "�� : " + "����к�" + "\n" + "�Ң��Ԫ� : " + major.Text + "\n"; //�� ID , ���� + �Ң� ���ʴ�
            }
            if (sp_1.Checked) // ��ͧ��������ö����� 1
            {
                ms += "��������ö����� : " + sp_1.Text + "\n";
            }
            if (sp_2.Checked) // ��ͧ��������ö����� 2
            {
                ms += "��������ö����� : " + sp_2.Text + "\n";
            }
            if (sp_3.Checked) // ��ͧ��������ö����� 3
            {
                ms += "��������ö����� : " + sp_3.Text + "\n";
            }
            if (sp_4.Checked) // ��ͧ��������ö����� 4
            {
                ms += "��������ö����� : " + sp_4.Text + "\n";
            }
            if (sp_5.Checked) // ��ͧ��������ö����� 5
            {
                ms += "��������ö����� : " + sp_5.Text + "\n";
            }
            if (sp_6.Checked) // ��ͧ��������ö����� 6
            {
                ms += "��������ö����� : " + sp_6.Text + "\n";
            }
            MessageBox.Show(ms); //�ʴ����Ѿ���繡��ͧ��ͤ���
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
                            case "��蹴����": sp_1.Checked = true; break;
                            case "��ͧ�ŧ": sp_2.Checked = true; break;
                            case "�����": sp_3.Checked = true; break;
                            case "����": sp_4.Checked = true; break;
                            case "��Ż�": sp_5.Checked = true; break;
                            case "����": sp_6.Checked = true; break;
                            case "���͡������": sp_7.Checked = true; break;
                        }
                    }
            }
            catch(Exception err)
            {
                
            }
        }
    }
}