
namespace demo_multi_chat
{
    partial class Client
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
            this.vmessage = new System.Windows.Forms.ListView();
            this.message = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vmessage
            // 
            this.vmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmessage.HideSelection = false;
            this.vmessage.Location = new System.Drawing.Point(14, 19);
            this.vmessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vmessage.Name = "vmessage";
            this.vmessage.Size = new System.Drawing.Size(738, 446);
            this.vmessage.TabIndex = 0;
            this.vmessage.UseCompatibleStateImageBehavior = false;
            this.vmessage.View = System.Windows.Forms.View.List;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(13, 633);
            this.message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(605, 87);
            this.message.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.LightGreen;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(661, 633);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(158, 87);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // nickname
            // 
            this.nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickname.Location = new System.Drawing.Point(14, 531);
            this.nickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(263, 27);
            this.nickname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 501);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 594);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // Client
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(832, 734);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.message);
            this.Controls.Add(this.vmessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vmessage;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

