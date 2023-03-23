
namespace DataStructure
{
    partial class ListTest
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bSearch1 = new System.Windows.Forms.Button();
            this.bSearch2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(57, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "number";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TextBox.Location = new System.Drawing.Point(142, 57);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(82, 31);
            this.TextBox.TabIndex = 1;
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bAdd.Location = new System.Drawing.Point(238, 57);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(90, 40);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bShow
            // 
            this.bShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bShow.Location = new System.Drawing.Point(345, 58);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(107, 40);
            this.bShow.TabIndex = 3;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // bDel
            // 
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bDel.Location = new System.Drawing.Point(238, 100);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(90, 40);
            this.bDel.TabIndex = 4;
            this.bDel.Text = "Delete";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bSearch1
            // 
            this.bSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bSearch1.Location = new System.Drawing.Point(345, 100);
            this.bSearch1.Name = "bSearch1";
            this.bSearch1.Size = new System.Drawing.Size(107, 40);
            this.bSearch1.TabIndex = 5;
            this.bSearch1.Text = "Search1";
            this.bSearch1.UseVisualStyleBackColor = true;
            this.bSearch1.Click += new System.EventHandler(this.bSearch1_Click);
            // 
            // bSearch2
            // 
            this.bSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bSearch2.Location = new System.Drawing.Point(345, 151);
            this.bSearch2.Name = "bSearch2";
            this.bSearch2.Size = new System.Drawing.Size(107, 40);
            this.bSearch2.TabIndex = 6;
            this.bSearch2.Text = "Search 2";
            this.bSearch2.UseVisualStyleBackColor = true;
            // 
            // ListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 270);
            this.Controls.Add(this.bSearch2);
            this.Controls.Add(this.bSearch1);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label1);
            this.Name = "ListTest";
            this.Text = "ListTest";
            this.Load += new System.EventHandler(this.ListTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bSearch1;
        private System.Windows.Forms.Button bSearch2;
    }
}