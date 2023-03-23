namespace DB_641413017
{
    partial class Picturebox
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
            this.Previous_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_641413017.Properties.Resources.meme_0;
            this.pictureBox1.Location = new System.Drawing.Point(229, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Previous_Button
            // 
            this.Previous_Button.Location = new System.Drawing.Point(276, 564);
            this.Previous_Button.Name = "Previous_Button";
            this.Previous_Button.Size = new System.Drawing.Size(112, 52);
            this.Previous_Button.TabIndex = 1;
            this.Previous_Button.Text = "Previous";
            this.Previous_Button.UseVisualStyleBackColor = true;
            this.Previous_Button.Click += new System.EventHandler(this.Previous_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.Location = new System.Drawing.Point(626, 564);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(112, 52);
            this.Next_Button.TabIndex = 2;
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Picturebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 689);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Previous_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Picturebox";
            this.Text = "Picturebox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Previous_Button;
        private Button Next_Button;
    }
}