
namespace DataStructure
{
    partial class QueueTest
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
            this.bEnqueue = new System.Windows.Forms.Button();
            this.queueNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nOfQueue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.service1 = new System.Windows.Forms.TextBox();
            this.service2 = new System.Windows.Forms.TextBox();
            this.service3 = new System.Windows.Forms.TextBox();
            this.bservice1 = new System.Windows.Forms.Button();
            this.bservice2 = new System.Windows.Forms.Button();
            this.bservice3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEnqueue
            // 
            this.bEnqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bEnqueue.Location = new System.Drawing.Point(75, 58);
            this.bEnqueue.Name = "bEnqueue";
            this.bEnqueue.Size = new System.Drawing.Size(88, 42);
            this.bEnqueue.TabIndex = 0;
            this.bEnqueue.Text = "เพิ่มคิว";
            this.bEnqueue.UseVisualStyleBackColor = true;
            this.bEnqueue.Click += new System.EventHandler(this.bEnqueue_Click);
            // 
            // queueNumber
            // 
            this.queueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.queueNumber.Location = new System.Drawing.Point(205, 61);
            this.queueNumber.Name = "queueNumber";
            this.queueNumber.Size = new System.Drawing.Size(153, 35);
            this.queueNumber.TabIndex = 1;
            this.queueNumber.Text = "0";
            this.queueNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(405, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "จำนวนคิว";
            // 
            // nOfQueue
            // 
            this.nOfQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nOfQueue.Location = new System.Drawing.Point(558, 61);
            this.nOfQueue.Name = "nOfQueue";
            this.nOfQueue.Size = new System.Drawing.Size(153, 35);
            this.nOfQueue.TabIndex = 3;
            this.nOfQueue.Text = "0";
            this.nOfQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ช่องที่ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(70, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "ช่องที่ 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(70, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "ช่องที่ 3";
            // 
            // service1
            // 
            this.service1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.service1.Location = new System.Drawing.Point(205, 150);
            this.service1.Name = "service1";
            this.service1.Size = new System.Drawing.Size(153, 35);
            this.service1.TabIndex = 7;
            // 
            // service2
            // 
            this.service2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.service2.Location = new System.Drawing.Point(205, 224);
            this.service2.Name = "service2";
            this.service2.Size = new System.Drawing.Size(153, 35);
            this.service2.TabIndex = 8;
            // 
            // service3
            // 
            this.service3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.service3.Location = new System.Drawing.Point(205, 291);
            this.service3.Name = "service3";
            this.service3.Size = new System.Drawing.Size(153, 35);
            this.service3.TabIndex = 9;
            // 
            // bservice1
            // 
            this.bservice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bservice1.Location = new System.Drawing.Point(410, 150);
            this.bservice1.Name = "bservice1";
            this.bservice1.Size = new System.Drawing.Size(116, 42);
            this.bservice1.TabIndex = 10;
            this.bservice1.Text = "เรียกคิว";
            this.bservice1.UseVisualStyleBackColor = true;
            // 
            // bservice2
            // 
            this.bservice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bservice2.Location = new System.Drawing.Point(410, 224);
            this.bservice2.Name = "bservice2";
            this.bservice2.Size = new System.Drawing.Size(116, 42);
            this.bservice2.TabIndex = 11;
            this.bservice2.Text = "เรียกคิว";
            this.bservice2.UseVisualStyleBackColor = true;
            // 
            // bservice3
            // 
            this.bservice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bservice3.Location = new System.Drawing.Point(410, 291);
            this.bservice3.Name = "bservice3";
            this.bservice3.Size = new System.Drawing.Size(116, 42);
            this.bservice3.TabIndex = 12;
            this.bservice3.Text = "เรียกคิว";
            this.bservice3.UseVisualStyleBackColor = true;
            // 
            // QueueTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 385);
            this.Controls.Add(this.bservice3);
            this.Controls.Add(this.bservice2);
            this.Controls.Add(this.bservice1);
            this.Controls.Add(this.service3);
            this.Controls.Add(this.service2);
            this.Controls.Add(this.service1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nOfQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queueNumber);
            this.Controls.Add(this.bEnqueue);
            this.Name = "QueueTest";
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.QueueTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnqueue;
        private System.Windows.Forms.TextBox queueNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nOfQueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox service1;
        private System.Windows.Forms.TextBox service2;
        private System.Windows.Forms.TextBox service3;
        private System.Windows.Forms.Button bservice1;
        private System.Windows.Forms.Button bservice2;
        private System.Windows.Forms.Button bservice3;
    }
}