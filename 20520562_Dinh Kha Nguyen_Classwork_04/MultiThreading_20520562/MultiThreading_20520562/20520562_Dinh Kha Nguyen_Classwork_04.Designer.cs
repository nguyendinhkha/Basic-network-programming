namespace MultiThreading_20520562
{
    partial class BTTL_MultiThreading_20520562
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
            this.btnThread1 = new System.Windows.Forms.Button();
            this.textN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThread2 = new System.Windows.Forms.Button();
            this.txtboxC1 = new System.Windows.Forms.TextBox();
            this.txtboxC2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number n:";
            this.label1.UseWaitCursor = true;
            // 
            // btnThread1
            // 
            this.btnThread1.BackColor = System.Drawing.Color.Turquoise;
            this.btnThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread1.Location = new System.Drawing.Point(111, 460);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(219, 68);
            this.btnThread1.TabIndex = 1;
            this.btnThread1.Text = "COUNT 1";
            this.btnThread1.UseVisualStyleBackColor = false;
            this.btnThread1.UseWaitCursor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // textN
            // 
            this.textN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textN.Location = new System.Drawing.Point(374, 100);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(388, 38);
            this.textN.TabIndex = 3;
            this.textN.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count to Number (1)";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count to Number (2)";
            this.label3.UseWaitCursor = true;
            // 
            // btnThread2
            // 
            this.btnThread2.BackColor = System.Drawing.Color.Turquoise;
            this.btnThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread2.Location = new System.Drawing.Point(517, 460);
            this.btnThread2.Name = "btnThread2";
            this.btnThread2.Size = new System.Drawing.Size(219, 68);
            this.btnThread2.TabIndex = 6;
            this.btnThread2.Text = "COUNT 2";
            this.btnThread2.UseVisualStyleBackColor = false;
            this.btnThread2.UseWaitCursor = true;
            this.btnThread2.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // txtboxC1
            // 
            this.txtboxC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxC1.Location = new System.Drawing.Point(110, 253);
            this.txtboxC1.Multiline = true;
            this.txtboxC1.Name = "txtboxC1";
            this.txtboxC1.Size = new System.Drawing.Size(219, 167);
            this.txtboxC1.TabIndex = 11;
            this.txtboxC1.UseWaitCursor = true;
            // 
            // txtboxC2
            // 
            this.txtboxC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxC2.Location = new System.Drawing.Point(517, 253);
            this.txtboxC2.Multiline = true;
            this.txtboxC2.Name = "txtboxC2";
            this.txtboxC2.Size = new System.Drawing.Size(219, 167);
            this.txtboxC2.TabIndex = 12;
            this.txtboxC2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(917, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "MSSV: 20520562";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(917, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Họ và tên: Nguyễn Đình Kha";
            this.label5.UseWaitCursor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(922, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 103);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.UseWaitCursor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.BlueViolet;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(922, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 103);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 46);
            this.label6.TabIndex = 17;
            this.label6.Text = "MultiThreading";
            this.label6.UseWaitCursor = true;
            // 
            // BTTL_MultiThreading_20520562
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxC2);
            this.Controls.Add(this.txtboxC1);
            this.Controls.Add(this.btnThread2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.btnThread1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BTTL_MultiThreading_20520562";
            this.Text = "BTTL_MULTITHREADING";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BTTL_MultiThreading_20520562_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThread2;
        private System.Windows.Forms.TextBox txtboxC1;
        private System.Windows.Forms.TextBox txtboxC2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
    }
}

