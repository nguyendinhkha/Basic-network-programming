
namespace Bai3_Client
{
    partial class TCPCLient
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
            this.btnTCPServer = new System.Windows.Forms.Button();
            this.btnTCPClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTCPServer
            // 
            this.btnTCPServer.Location = new System.Drawing.Point(93, 71);
            this.btnTCPServer.Name = "btnTCPServer";
            this.btnTCPServer.Size = new System.Drawing.Size(160, 55);
            this.btnTCPServer.TabIndex = 0;
            this.btnTCPServer.Text = "Open TCP Server";
            this.btnTCPServer.UseVisualStyleBackColor = true;
            this.btnTCPServer.Click += new System.EventHandler(this.btnTCPServer_Click);
            // 
            // btnTCPClient
            // 
            this.btnTCPClient.Location = new System.Drawing.Point(93, 202);
            this.btnTCPClient.Name = "btnTCPClient";
            this.btnTCPClient.Size = new System.Drawing.Size(160, 57);
            this.btnTCPClient.TabIndex = 1;
            this.btnTCPClient.Text = "Open TCP Client";
            this.btnTCPClient.UseVisualStyleBackColor = true;
            this.btnTCPClient.Click += new System.EventHandler(this.btnTCPClient_Click);
            // 
            // TCPCLient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 345);
            this.Controls.Add(this.btnTCPClient);
            this.Controls.Add(this.btnTCPServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TCPCLient";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTCPServer;
        private System.Windows.Forms.Button btnTCPClient;
    }
}

