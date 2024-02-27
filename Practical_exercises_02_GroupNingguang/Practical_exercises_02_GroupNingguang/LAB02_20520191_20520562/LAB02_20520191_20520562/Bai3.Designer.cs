namespace LAB02_20520191_20520562
{
    partial class Bai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.ListView();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bài 03 - Ghi file (mở rộng)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "MSSV: 20520562";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên: Nguyễn Đình Kha";
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReadFile.Location = new System.Drawing.Point(43, 127);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(188, 94);
            this.buttonReadFile.TabIndex = 6;
            this.buttonReadFile.Text = "Đọc file";
            this.buttonReadFile.UseVisualStyleBackColor = false;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSaveFile.Location = new System.Drawing.Point(43, 457);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(188, 94);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Lưu file";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // View
            // 
            this.View.HideSelection = false;
            this.View.Location = new System.Drawing.Point(504, 40);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(671, 607);
            this.View.TabIndex = 8;
            this.View.UseCompatibleStateImageBehavior = false;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Aquamarine;
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculate.Location = new System.Drawing.Point(43, 293);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(188, 94);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Tính";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.View);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai3";
            this.Text = "Bai 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.ListView View;
        private System.Windows.Forms.Button calculate;
    }
}