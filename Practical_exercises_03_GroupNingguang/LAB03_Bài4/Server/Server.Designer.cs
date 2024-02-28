
namespace Server
{
    partial class Server
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
            this.Send = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.vmessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(677, 54);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(129, 61);
            this.Send.TabIndex = 5;
            this.Send.Text = "Listen";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(13, 56);
            this.message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(661, 59);
            this.message.TabIndex = 4;
            // 
            // vmessage
            // 
            this.vmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmessage.HideSelection = false;
            this.vmessage.Location = new System.Drawing.Point(13, 170);
            this.vmessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vmessage.Name = "vmessage";
            this.vmessage.Size = new System.Drawing.Size(793, 519);
            this.vmessage.TabIndex = 3;
            this.vmessage.UseCompatibleStateImageBehavior = false;
            this.vmessage.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(843, 703);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.vmessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ListView vmessage;
    }
}

