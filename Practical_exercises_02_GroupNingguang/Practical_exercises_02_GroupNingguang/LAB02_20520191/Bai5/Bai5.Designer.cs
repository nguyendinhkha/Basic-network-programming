
namespace Bai5
{
    partial class Bai5
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
            this.btnRead = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.ListView();
            this.file_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file_size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.file_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(50, 34);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(117, 47);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // view
            // 
            this.view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file_name,
            this.file_size,
            this.file_type,
            this.file_date});
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.HideSelection = false;
            this.view.Location = new System.Drawing.Point(5, 115);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(804, 329);
            this.view.TabIndex = 1;
            this.view.UseCompatibleStateImageBehavior = false;
            this.view.View = System.Windows.Forms.View.Details;
            // 
            // file_name
            // 
            this.file_name.Text = "Tên file";
            this.file_name.Width = 200;
            // 
            // file_size
            // 
            this.file_size.Text = "Kích thước";
            this.file_size.Width = 150;
            // 
            // file_type
            // 
            this.file_type.Text = "Đuôi mở rộng";
            this.file_type.Width = 150;
            // 
            // file_date
            // 
            this.file_date.Text = "Ngày tạo";
            this.file_date.Width = 300;
            // 
            // Bai5
            // 
            this.AcceptButton = this.btnRead;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.view);
            this.Controls.Add(this.btnRead);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListView view;
        private System.Windows.Forms.ColumnHeader file_name;
        private System.Windows.Forms.ColumnHeader file_size;
        private System.Windows.Forms.ColumnHeader file_type;
        private System.Windows.Forms.ColumnHeader file_date;
    }
}

