namespace LAB4_Bai4
{
    partial class ViewSource
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
            this.rc_ViewSource = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rc_ViewSource
            // 
            this.rc_ViewSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rc_ViewSource.Location = new System.Drawing.Point(0, 0);
            this.rc_ViewSource.Name = "rc_ViewSource";
            this.rc_ViewSource.Size = new System.Drawing.Size(1000, 562);
            this.rc_ViewSource.TabIndex = 0;
            this.rc_ViewSource.Text = "";
            // 
            // ViewSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.rc_ViewSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewSource";
            this.Text = "ViewSourceHTML_20520562";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rc_ViewSource;
    }
}