namespace ATRIX_LTM
{
    partial class ControlRemote
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
            this.txtb_ip = new System.Windows.Forms.TextBox();
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.lb_passwd = new System.Windows.Forms.Label();
            this.txtb_pass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_disconnect = new FontAwesome.Sharp.IconButton();
            this.btn_connect = new FontAwesome.Sharp.IconButton();
            this.btn_ping = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_ip
            // 
            this.txtb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_ip.Location = new System.Drawing.Point(181, 44);
            this.txtb_ip.Name = "txtb_ip";
            this.txtb_ip.Size = new System.Drawing.Size(187, 27);
            this.txtb_ip.TabIndex = 0;
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ip.Location = new System.Drawing.Point(53, 47);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(91, 20);
            this.lb_ip.TabIndex = 1;
            this.lb_ip.Text = "IP Address";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(53, 106);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(94, 20);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "User Name";
            // 
            // txtb_username
            // 
            this.txtb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_username.Location = new System.Drawing.Point(181, 103);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(187, 27);
            this.txtb_username.TabIndex = 2;
            // 
            // lb_passwd
            // 
            this.lb_passwd.AutoSize = true;
            this.lb_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_passwd.Location = new System.Drawing.Point(53, 161);
            this.lb_passwd.Name = "lb_passwd";
            this.lb_passwd.Size = new System.Drawing.Size(83, 20);
            this.lb_passwd.TabIndex = 5;
            this.lb_passwd.Text = "Password";
            // 
            // txtb_pass
            // 
            this.txtb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_pass.Location = new System.Drawing.Point(181, 158);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.Size = new System.Drawing.Size(187, 27);
            this.txtb_pass.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtb_ip);
            this.groupBox1.Controls.Add(this.lb_ip);
            this.groupBox1.Controls.Add(this.lb_passwd);
            this.groupBox1.Controls.Add(this.txtb_username);
            this.groupBox1.Controls.Add(this.txtb_pass);
            this.groupBox1.Controls.Add(this.lb_username);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_disconnect.IconColor = System.Drawing.Color.Black;
            this.btn_disconnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_disconnect.Location = new System.Drawing.Point(12, 382);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(882, 52);
            this.btn_disconnect.TabIndex = 9;
            this.btn_disconnect.Text = "DISCONNECT";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connect.Enabled = false;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_connect.IconColor = System.Drawing.Color.Black;
            this.btn_connect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_connect.Location = new System.Drawing.Point(12, 324);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(882, 52);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_ping
            // 
            this.btn_ping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ping.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ping.IconColor = System.Drawing.Color.Black;
            this.btn_ping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ping.Location = new System.Drawing.Point(657, 201);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(125, 66);
            this.btn_ping.TabIndex = 6;
            this.btn_ping.Text = "PING";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // ControlRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 446);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlRemote";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_ip;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.Label lb_passwd;
        private System.Windows.Forms.TextBox txtb_pass;
        private FontAwesome.Sharp.IconButton btn_ping;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_connect;
        private FontAwesome.Sharp.IconButton btn_disconnect;
    }
}