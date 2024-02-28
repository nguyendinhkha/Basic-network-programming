namespace Lab4_Bai2
{
    partial class Bai2
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
            this.view = new System.Windows.Forms.RichTextBox();
            this.getUrl = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.post_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(12, 107);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(463, 415);
            this.view.TabIndex = 5;
            this.view.Text = "";
            // 
            // getUrl
            // 
            this.getUrl.Location = new System.Drawing.Point(12, 12);
            this.getUrl.Name = "getUrl";
            this.getUrl.Size = new System.Drawing.Size(363, 27);
            this.getUrl.TabIndex = 4;
            this.getUrl.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(381, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(94, 29);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // post_value
            // 
            this.post_value.Location = new System.Drawing.Point(12, 60);
            this.post_value.Name = "post_value";
            this.post_value.Size = new System.Drawing.Size(363, 27);
            this.post_value.TabIndex = 6;
            // 
            // Bai2
            // 
            this.AcceptButton = this.btnPost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 534);
            this.Controls.Add(this.post_value);
            this.Controls.Add(this.view);
            this.Controls.Add(this.getUrl);
            this.Controls.Add(this.btnPost);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox view;
        private TextBox getUrl;
        private Button btnPost;
        private TextBox post_value;
    }
}