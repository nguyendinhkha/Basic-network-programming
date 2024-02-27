
namespace ATRIX_LTM
{
    partial class PCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCForm));
            this.rdp = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // rdp
            // 
            this.rdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(0, 0);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(1920, 1001);
            this.rdp.TabIndex = 0;
            this.rdp.OnConnecting += new System.EventHandler(this.rdp_OnConnecting);
            // 
            // PCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1001);
            this.Controls.Add(this.rdp);
            this.Name = "PCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PCForm_FormClosing);
            this.Load += new System.EventHandler(this.PCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting rdp;
    }
}