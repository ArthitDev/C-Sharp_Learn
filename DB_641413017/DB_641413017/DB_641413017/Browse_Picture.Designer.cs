﻿namespace DB_641413017
{
    partial class Browse_Picture
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Browse_Click = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_641413017.Properties.Resources.meme_0;
            this.pictureBox1.Location = new System.Drawing.Point(176, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Browse_Click
            // 
            this.Browse_Click.Location = new System.Drawing.Point(360, 493);
            this.Browse_Click.Name = "Browse_Click";
            this.Browse_Click.Size = new System.Drawing.Size(171, 52);
            this.Browse_Click.TabIndex = 1;
            this.Browse_Click.Text = "Browse Picture";
            this.Browse_Click.UseVisualStyleBackColor = true;
            this.Browse_Click.Click += new System.EventHandler(this.Browse_Click_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Browse_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 607);
            this.Controls.Add(this.Browse_Click);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Browse_Picture";
            this.Text = "Browse_Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Browse_Click;
        private OpenFileDialog openFileDialog1;
    }
}