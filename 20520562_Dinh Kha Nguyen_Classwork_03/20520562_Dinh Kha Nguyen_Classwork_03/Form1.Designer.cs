namespace _20520562_Bai_Tap_Tai_Lop_03
{
    partial class Form1
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
            this.textURL = new System.Windows.Forms.TextBox();
            this.fileSaveDes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnGetFileDes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(289, 39);
            this.textURL.Multiline = true;
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(600, 39);
            this.textURL.TabIndex = 0;
            // 
            // fileSaveDes
            // 
            this.fileSaveDes.Location = new System.Drawing.Point(289, 95);
            this.fileSaveDes.Multiline = true;
            this.fileSaveDes.Name = "fileSaveDes";
            this.fileSaveDes.Size = new System.Drawing.Size(600, 39);
            this.fileSaveDes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "File destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Content:";
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(36, 205);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(1070, 441);
            this.txtView.TabIndex = 9;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(944, 32);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(162, 39);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Aquamarine;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(944, 160);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(162, 39);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // btnGetFileDes
            // 
            this.btnGetFileDes.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGetFileDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFileDes.Location = new System.Drawing.Point(944, 95);
            this.btnGetFileDes.Name = "btnGetFileDes";
            this.btnGetFileDes.Size = new System.Drawing.Size(162, 39);
            this.btnGetFileDes.TabIndex = 12;
            this.btnGetFileDes.Text = "Get file destination";
            this.btnGetFileDes.UseVisualStyleBackColor = false;
            this.btnGetFileDes.Click += new System.EventHandler(this.btnGetFileDes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnGetFileDes);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileSaveDes);
            this.Controls.Add(this.textURL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bài tập tại lớp 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.TextBox fileSaveDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnGetFileDes;
    }
}

