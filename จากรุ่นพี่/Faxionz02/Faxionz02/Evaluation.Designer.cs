namespace Faxionz02
{
    partial class Evaluation
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
            this.label2 = new System.Windows.Forms.Label();
            this.gSex = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.gEmployment = new System.Windows.Forms.ComboBox();
            this.gSalary = new System.Windows.Forms.GroupBox();
            this.salary4 = new System.Windows.Forms.RadioButton();
            this.salary3 = new System.Windows.Forms.RadioButton();
            this.salary1 = new System.Windows.Forms.RadioButton();
            this.salary2 = new System.Windows.Forms.RadioButton();
            this.gContent = new System.Windows.Forms.GroupBox();
            this.content1 = new System.Windows.Forms.RadioButton();
            this.content2 = new System.Windows.Forms.RadioButton();
            this.content3 = new System.Windows.Forms.RadioButton();
            this.content5 = new System.Windows.Forms.RadioButton();
            this.content4 = new System.Windows.Forms.RadioButton();
            this.bNew = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bReport = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.gSex.SuspendLayout();
            this.gSalary.SuspendLayout();
            this.gContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "อาชีพ";
            // 
            // gSex
            // 
            this.gSex.Controls.Add(this.female);
            this.gSex.Controls.Add(this.male);
            this.gSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gSex.Location = new System.Drawing.Point(18, 12);
            this.gSex.Name = "gSex";
            this.gSex.Size = new System.Drawing.Size(204, 101);
            this.gSex.TabIndex = 4;
            this.gSex.TabStop = false;
            this.gSex.Text = "เพศ";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(104, 37);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 33);
            this.female.TabIndex = 7;
            this.female.TabStop = true;
            this.female.Text = "หญิง";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(6, 37);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(66, 33);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "ชาย";
            this.male.UseVisualStyleBackColor = true;
            // 
            // gEmployment
            // 
            this.gEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gEmployment.FormattingEnabled = true;
            this.gEmployment.Items.AddRange(new object[] {
            "นักเรียน-นักศึกษา",
            "รับราชการ",
            "พนักงานบริษัท/ห้างร้าน",
            "ธุรกิจส่วนตัว/ค้าขาย",
            "ไลน์แมน"});
            this.gEmployment.Location = new System.Drawing.Point(101, 135);
            this.gEmployment.Name = "gEmployment";
            this.gEmployment.Size = new System.Drawing.Size(266, 37);
            this.gEmployment.TabIndex = 5;
            this.gEmployment.SelectedIndexChanged += new System.EventHandler(this.employment_SelectedIndexChanged);
            // 
            // gSalary
            // 
            this.gSalary.Controls.Add(this.salary4);
            this.gSalary.Controls.Add(this.salary3);
            this.gSalary.Controls.Add(this.salary1);
            this.gSalary.Controls.Add(this.salary2);
            this.gSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gSalary.Location = new System.Drawing.Point(18, 206);
            this.gSalary.Name = "gSalary";
            this.gSalary.Size = new System.Drawing.Size(349, 181);
            this.gSalary.TabIndex = 8;
            this.gSalary.TabStop = false;
            this.gSalary.Text = "เงินเดือน";
            // 
            // salary4
            // 
            this.salary4.AutoSize = true;
            this.salary4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.salary4.Location = new System.Drawing.Point(174, 87);
            this.salary4.Name = "salary4";
            this.salary4.Size = new System.Drawing.Size(161, 33);
            this.salary4.TabIndex = 9;
            this.salary4.TabStop = true;
            this.salary4.Text = "มากว่า 40000";
            this.salary4.UseVisualStyleBackColor = true;
            // 
            // salary3
            // 
            this.salary3.AutoSize = true;
            this.salary3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.salary3.Location = new System.Drawing.Point(0, 87);
            this.salary3.Name = "salary3";
            this.salary3.Size = new System.Drawing.Size(169, 33);
            this.salary3.TabIndex = 8;
            this.salary3.TabStop = true;
            this.salary3.Text = "20001-40000";
            this.salary3.UseVisualStyleBackColor = true;
            // 
            // salary1
            // 
            this.salary1.AutoSize = true;
            this.salary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.salary1.Location = new System.Drawing.Point(0, 37);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(160, 33);
            this.salary1.TabIndex = 7;
            this.salary1.TabStop = true;
            this.salary1.Text = "ต่ำกว่า 15000";
            this.salary1.UseVisualStyleBackColor = true;
            // 
            // salary2
            // 
            this.salary2.AutoSize = true;
            this.salary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.salary2.Location = new System.Drawing.Point(174, 37);
            this.salary2.Name = "salary2";
            this.salary2.Size = new System.Drawing.Size(169, 33);
            this.salary2.TabIndex = 6;
            this.salary2.TabStop = true;
            this.salary2.Text = "15001-20000";
            this.salary2.UseVisualStyleBackColor = true;
            // 
            // gContent
            // 
            this.gContent.Controls.Add(this.content1);
            this.gContent.Controls.Add(this.content2);
            this.gContent.Controls.Add(this.content3);
            this.gContent.Controls.Add(this.content5);
            this.gContent.Controls.Add(this.content4);
            this.gContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gContent.Location = new System.Drawing.Point(18, 393);
            this.gContent.Name = "gContent";
            this.gContent.Size = new System.Drawing.Size(349, 77);
            this.gContent.TabIndex = 10;
            this.gContent.TabStop = false;
            this.gContent.Text = "ความพึงพอใจ";
            // 
            // content1
            // 
            this.content1.AutoSize = true;
            this.content1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.content1.Location = new System.Drawing.Point(200, 37);
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(44, 33);
            this.content1.TabIndex = 11;
            this.content1.TabStop = true;
            this.content1.Text = "1";
            this.content1.UseVisualStyleBackColor = true;
            // 
            // content2
            // 
            this.content2.AutoSize = true;
            this.content2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.content2.Location = new System.Drawing.Point(150, 37);
            this.content2.Name = "content2";
            this.content2.Size = new System.Drawing.Size(44, 33);
            this.content2.TabIndex = 9;
            this.content2.TabStop = true;
            this.content2.Text = "2";
            this.content2.UseVisualStyleBackColor = true;
            // 
            // content3
            // 
            this.content3.AutoSize = true;
            this.content3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.content3.Location = new System.Drawing.Point(100, 37);
            this.content3.Name = "content3";
            this.content3.Size = new System.Drawing.Size(44, 33);
            this.content3.TabIndex = 8;
            this.content3.TabStop = true;
            this.content3.Text = "3";
            this.content3.UseVisualStyleBackColor = true;
            // 
            // content5
            // 
            this.content5.AutoSize = true;
            this.content5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.content5.Location = new System.Drawing.Point(0, 37);
            this.content5.Name = "content5";
            this.content5.Size = new System.Drawing.Size(44, 33);
            this.content5.TabIndex = 7;
            this.content5.TabStop = true;
            this.content5.Text = "5";
            this.content5.UseVisualStyleBackColor = true;
            // 
            // content4
            // 
            this.content4.AutoSize = true;
            this.content4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.content4.Location = new System.Drawing.Point(50, 37);
            this.content4.Name = "content4";
            this.content4.Size = new System.Drawing.Size(44, 33);
            this.content4.TabIndex = 6;
            this.content4.TabStop = true;
            this.content4.Text = "4";
            this.content4.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bNew.Location = new System.Drawing.Point(77, 512);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(124, 64);
            this.bNew.TabIndex = 11;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bSave.Location = new System.Drawing.Point(207, 512);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(124, 64);
            this.bSave.TabIndex = 12;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bReport
            // 
            this.bReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bReport.Location = new System.Drawing.Point(467, 512);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(124, 64);
            this.bReport.TabIndex = 13;
            this.bReport.Text = "Report";
            this.bReport.UseVisualStyleBackColor = true;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bExit.Location = new System.Drawing.Point(597, 512);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(124, 64);
            this.bExit.TabIndex = 14;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bShow
            // 
            this.bShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bShow.Location = new System.Drawing.Point(337, 512);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(124, 64);
            this.bShow.TabIndex = 15;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 643);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bReport);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.gContent);
            this.Controls.Add(this.gSalary);
            this.Controls.Add(this.gEmployment);
            this.Controls.Add(this.gSex);
            this.Controls.Add(this.label2);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.gSex.ResumeLayout(false);
            this.gSex.PerformLayout();
            this.gSalary.ResumeLayout(false);
            this.gSalary.PerformLayout();
            this.gContent.ResumeLayout(false);
            this.gContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gSex;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.ComboBox gEmployment;
        private System.Windows.Forms.GroupBox gSalary;
        private System.Windows.Forms.RadioButton salary4;
        private System.Windows.Forms.RadioButton salary3;
        private System.Windows.Forms.RadioButton salary1;
        private System.Windows.Forms.RadioButton salary2;
        private System.Windows.Forms.GroupBox gContent;
        private System.Windows.Forms.RadioButton content1;
        private System.Windows.Forms.RadioButton content2;
        private System.Windows.Forms.RadioButton content3;
        private System.Windows.Forms.RadioButton content5;
        private System.Windows.Forms.RadioButton content4;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bReport;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bShow;
    }
}