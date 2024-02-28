namespace Lab4_Bai1
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGet = new System.Windows.Forms.Button();
            this.getUrl = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGet.Location = new System.Drawing.Point(381, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(94, 29);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click_1);
            // 
            // getUrl
            // 
            this.getUrl.Location = new System.Drawing.Point(12, 12);
            this.getUrl.Name = "getUrl";
            this.getUrl.Size = new System.Drawing.Size(363, 27);
            this.getUrl.TabIndex = 1;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(12, 56);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(463, 382);
            this.view.TabIndex = 2;
            this.view.Text = "";
            // 
            // Bai1
            // 
            this.AcceptButton = this.btnGet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.view);
            this.Controls.Add(this.getUrl);
            this.Controls.Add(this.btnGet);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGet;
        private TextBox getUrl;
        private RichTextBox view;
    }
}