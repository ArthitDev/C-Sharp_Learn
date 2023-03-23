namespace Faxionz02
{
    partial class Finance
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
            this.label1 = new System.Windows.Forms.Label();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.tDown_pm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tAmount_Year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tNum_Of_Periods = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tAnnuity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tRate_All = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tRate_Year = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tNew = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ราคา";
            // 
            // tPrice
            // 
            this.tPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tPrice.Location = new System.Drawing.Point(203, 19);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(100, 35);
            this.tPrice.TabIndex = 1;
            this.tPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tPrice_KeyDown);
            // 
            // tDown_pm
            // 
            this.tDown_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tDown_pm.Location = new System.Drawing.Point(203, 60);
            this.tDown_pm.Name = "tDown_pm";
            this.tDown_pm.Size = new System.Drawing.Size(100, 35);
            this.tDown_pm.TabIndex = 3;
            this.tDown_pm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tDown_pm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "เงินดาวน์";
            // 
            // tAmount
            // 
            this.tAmount.Enabled = false;
            this.tAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tAmount.Location = new System.Drawing.Point(203, 101);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(100, 35);
            this.tAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(58, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "ยอดจัด";
            // 
            // tRate
            // 
            this.tRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tRate.Location = new System.Drawing.Point(203, 142);
            this.tRate.Name = "tRate";
            this.tRate.Size = new System.Drawing.Size(100, 35);
            this.tRate.TabIndex = 7;
            this.tRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tRate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(58, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "อัตราดอกเบี้ย";
            // 
            // tAmount_Year
            // 
            this.tAmount_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tAmount_Year.Location = new System.Drawing.Point(203, 183);
            this.tAmount_Year.Name = "tAmount_Year";
            this.tAmount_Year.Size = new System.Drawing.Size(100, 35);
            this.tAmount_Year.TabIndex = 9;
            this.tAmount_Year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tAmount_Year_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(58, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "จำนวนปี";
            // 
            // tNum_Of_Periods
            // 
            this.tNum_Of_Periods.Enabled = false;
            this.tNum_Of_Periods.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tNum_Of_Periods.Location = new System.Drawing.Point(203, 224);
            this.tNum_Of_Periods.Name = "tNum_Of_Periods";
            this.tNum_Of_Periods.Size = new System.Drawing.Size(100, 35);
            this.tNum_Of_Periods.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(58, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "จำนวนงวด";
            // 
            // tAnnuity
            // 
            this.tAnnuity.Enabled = false;
            this.tAnnuity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tAnnuity.Location = new System.Drawing.Point(203, 265);
            this.tAnnuity.Name = "tAnnuity";
            this.tAnnuity.Size = new System.Drawing.Size(100, 35);
            this.tAnnuity.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(58, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "เงินงวด";
            // 
            // tRate_All
            // 
            this.tRate_All.Enabled = false;
            this.tRate_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tRate_All.Location = new System.Drawing.Point(509, 224);
            this.tRate_All.Name = "tRate_All";
            this.tRate_All.Size = new System.Drawing.Size(100, 35);
            this.tRate_All.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(350, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "ดอกเบี้ยทั้งหมด";
            // 
            // tRate_Year
            // 
            this.tRate_Year.Enabled = false;
            this.tRate_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tRate_Year.Location = new System.Drawing.Point(509, 183);
            this.tRate_Year.Name = "tRate_Year";
            this.tRate_Year.Size = new System.Drawing.Size(100, 35);
            this.tRate_Year.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(350, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "ดอกเบี้ยต่อปี";
            // 
            // tBalance
            // 
            this.tBalance.Enabled = false;
            this.tBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tBalance.Location = new System.Drawing.Point(509, 265);
            this.tBalance.Name = "tBalance";
            this.tBalance.Size = new System.Drawing.Size(100, 35);
            this.tBalance.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(350, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "ยอดหนี้";
            // 
            // tNew
            // 
            this.tNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tNew.Location = new System.Drawing.Point(227, 380);
            this.tNew.Name = "tNew";
            this.tNew.Size = new System.Drawing.Size(108, 63);
            this.tNew.TabIndex = 21;
            this.tNew.Text = "New";
            this.tNew.UseVisualStyleBackColor = true;
            this.tNew.Click += new System.EventHandler(this.tNew_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bExit.Location = new System.Drawing.Point(395, 380);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(108, 63);
            this.bExit.TabIndex = 22;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 540);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tNew);
            this.Controls.Add(this.tBalance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tAnnuity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tRate_All);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tRate_Year);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tNum_Of_Periods);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tAmount_Year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tDown_pm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.label1);
            this.Name = "Finance";
            this.Text = "Finance";
            this.Load += new System.EventHandler(this.Finance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.TextBox tDown_pm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tAmount_Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tNum_Of_Periods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tAnnuity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tRate_All;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tRate_Year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tNew;
        private System.Windows.Forms.Button bExit;
    }
}