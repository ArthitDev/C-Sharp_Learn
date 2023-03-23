namespace Grade
{
    partial class ListStructure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Button = new System.Windows.Forms.Button();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Phone_box = new System.Windows.Forms.TextBox();
            this.Lable_Name = new System.Windows.Forms.Label();
            this.Lable_Phone = new System.Windows.Forms.Label();
            this.Phone_Start_End = new System.Windows.Forms.Button();
            this.Phone_End_Start = new System.Windows.Forms.Button();
            this.Phone_Sort_No = new System.Windows.Forms.Button();
            this.Search_By_Name = new System.Windows.Forms.Button();
            this.Delete_Phone = new System.Windows.Forms.Button();
            this.End_Program = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_Button.Location = new System.Drawing.Point(512, 113);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(116, 41);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Name_box
            // 
            this.Name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_box.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_box.Location = new System.Drawing.Point(209, 47);
            this.Name_box.Multiline = true;
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(434, 48);
            this.Name_box.TabIndex = 1;
            this.Name_box.Tag = "";
            this.Name_box.TextChanged += new System.EventHandler(this.Name_box_TextChanged);
            // 
            // Phone_box
            // 
            this.Phone_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_box.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_box.Location = new System.Drawing.Point(209, 117);
            this.Phone_box.MaxLength = 10;
            this.Phone_box.Multiline = true;
            this.Phone_box.Name = "Phone_box";
            this.Phone_box.Size = new System.Drawing.Size(266, 48);
            this.Phone_box.TabIndex = 2;
            this.Phone_box.TextChanged += new System.EventHandler(this.Phone_box_TextChanged);
            // 
            // Lable_Name
            // 
            this.Lable_Name.AutoSize = true;
            this.Lable_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Name.Location = new System.Drawing.Point(141, 58);
            this.Lable_Name.Name = "Lable_Name";
            this.Lable_Name.Size = new System.Drawing.Size(47, 37);
            this.Lable_Name.TabIndex = 3;
            this.Lable_Name.Text = "ชื่อ";
            // 
            // Lable_Phone
            // 
            this.Lable_Phone.AutoSize = true;
            this.Lable_Phone.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Phone.Location = new System.Drawing.Point(40, 117);
            this.Lable_Phone.Name = "Lable_Phone";
            this.Lable_Phone.Size = new System.Drawing.Size(148, 37);
            this.Lable_Phone.TabIndex = 4;
            this.Lable_Phone.Text = "เบอร์โทรศัพท์";
            // 
            // Phone_Start_End
            // 
            this.Phone_Start_End.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Start_End.Location = new System.Drawing.Point(163, 225);
            this.Phone_Start_End.Name = "Phone_Start_End";
            this.Phone_Start_End.Size = new System.Drawing.Size(446, 59);
            this.Phone_Start_End.TabIndex = 5;
            this.Phone_Start_End.Text = "แสดงเบอร์โทรเบอร์แรกถึงเบอร์สุดท้าย";
            this.Phone_Start_End.UseVisualStyleBackColor = true;
            this.Phone_Start_End.Click += new System.EventHandler(this.Phone_Start_End_Click);
            // 
            // Phone_End_Start
            // 
            this.Phone_End_Start.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_End_Start.Location = new System.Drawing.Point(163, 303);
            this.Phone_End_Start.Name = "Phone_End_Start";
            this.Phone_End_Start.Size = new System.Drawing.Size(446, 54);
            this.Phone_End_Start.TabIndex = 6;
            this.Phone_End_Start.Text = "แสดงเบอร์โทรสุดท้ายไปเบอร์แรก";
            this.Phone_End_Start.UseVisualStyleBackColor = true;
            this.Phone_End_Start.Click += new System.EventHandler(this.Phone_End_Start_Click);
            // 
            // Phone_Sort_No
            // 
            this.Phone_Sort_No.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Sort_No.Location = new System.Drawing.Point(163, 379);
            this.Phone_Sort_No.Name = "Phone_Sort_No";
            this.Phone_Sort_No.Size = new System.Drawing.Size(446, 54);
            this.Phone_Sort_No.TabIndex = 7;
            this.Phone_Sort_No.Text = "แสดงเบอร์โทรแบบเรียงลำดับเบอร์";
            this.Phone_Sort_No.UseVisualStyleBackColor = true;
            this.Phone_Sort_No.Click += new System.EventHandler(this.Phone_Sort_No_Click);
            // 
            // Search_By_Name
            // 
            this.Search_By_Name.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_By_Name.Location = new System.Drawing.Point(163, 463);
            this.Search_By_Name.Name = "Search_By_Name";
            this.Search_By_Name.Size = new System.Drawing.Size(434, 55);
            this.Search_By_Name.TabIndex = 8;
            this.Search_By_Name.Text = "ค้นหาเบอร์โทรศัพท์ตามชื่อ";
            this.Search_By_Name.UseVisualStyleBackColor = true;
            this.Search_By_Name.Click += new System.EventHandler(this.Search_By_Name_Click);
            // 
            // Delete_Phone
            // 
            this.Delete_Phone.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Phone.Location = new System.Drawing.Point(163, 550);
            this.Delete_Phone.Name = "Delete_Phone";
            this.Delete_Phone.Size = new System.Drawing.Size(434, 54);
            this.Delete_Phone.TabIndex = 9;
            this.Delete_Phone.Text = "ลบเบอร์โทรศัพท์";
            this.Delete_Phone.UseVisualStyleBackColor = true;
            this.Delete_Phone.Click += new System.EventHandler(this.Delete_Phone_Click);
            // 
            // End_Program
            // 
            this.End_Program.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Program.Location = new System.Drawing.Point(439, 649);
            this.End_Program.Name = "End_Program";
            this.End_Program.Size = new System.Drawing.Size(158, 61);
            this.End_Program.TabIndex = 10;
            this.End_Program.Text = "จบการทำงาน";
            this.End_Program.UseVisualStyleBackColor = true;
            this.End_Program.Click += new System.EventHandler(this.End_Program_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(163, 649);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(185, 61);
            this.Clear_Button.TabIndex = 11;
            this.Clear_Button.Text = "ลบข้อมูลทั้งหมด";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // ListStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.End_Program);
            this.Controls.Add(this.Delete_Phone);
            this.Controls.Add(this.Search_By_Name);
            this.Controls.Add(this.Phone_Sort_No);
            this.Controls.Add(this.Phone_End_Start);
            this.Controls.Add(this.Phone_Start_End);
            this.Controls.Add(this.Lable_Phone);
            this.Controls.Add(this.Lable_Name);
            this.Controls.Add(this.Phone_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.Add_Button);
            this.Name = "ListStructure";
            this.Text = " รายการเบอร์โทรศัพท์";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Phone_box;
        private System.Windows.Forms.Label Lable_Name;
        private System.Windows.Forms.Label Lable_Phone;
        private System.Windows.Forms.Button Phone_Start_End;
        private System.Windows.Forms.Button Phone_End_Start;
        private System.Windows.Forms.Button Phone_Sort_No;
        private System.Windows.Forms.Button Search_By_Name;
        private System.Windows.Forms.Button Delete_Phone;
        private System.Windows.Forms.Button End_Program;
        private System.Windows.Forms.Button Clear_Button;
    }
}