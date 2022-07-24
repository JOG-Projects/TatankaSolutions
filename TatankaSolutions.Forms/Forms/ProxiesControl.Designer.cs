namespace ConvertText.Forms
{
    partial class ProxiesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tb_Ip = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddProxy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Proxies = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Tb_Ip);
            this.panel1.Controls.Add(this.btn_Run);
            this.panel1.Controls.Add(this.Tb_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_AddProxy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Tb_User);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(619, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 449);
            this.panel1.TabIndex = 11;
            // 
            // Tb_Ip
            // 
            this.Tb_Ip.Location = new System.Drawing.Point(103, 60);
            this.Tb_Ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tb_Ip.Name = "Tb_Ip";
            this.Tb_Ip.Size = new System.Drawing.Size(249, 27);
            this.Tb_Ip.TabIndex = 1;
            // 
            // btn_Run
            // 
            this.btn_Run.BackgroundImage = global::TatankaSolutions.Forms.Properties.Resources.play_icon_134504;
            this.btn_Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Run.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Run.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Run.Location = new System.Drawing.Point(57, 176);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(414, 201);
            this.btn_Run.TabIndex = 5;
            this.btn_Run.UseVisualStyleBackColor = false;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(103, 137);
            this.Tb_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.Size = new System.Drawing.Size(249, 27);
            this.Tb_Password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "User:";
            // 
            // btn_AddProxy
            // 
            this.btn_AddProxy.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddProxy.BackgroundImage = global::TatankaSolutions.Forms.Properties.Resources._7630ad49bdc79b8482c8627c663a1373;
            this.btn_AddProxy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddProxy.Location = new System.Drawing.Point(371, 60);
            this.btn_AddProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddProxy.Name = "btn_AddProxy";
            this.btn_AddProxy.Size = new System.Drawing.Size(98, 108);
            this.btn_AddProxy.TabIndex = 4;
            this.btn_AddProxy.UseVisualStyleBackColor = false;
            this.btn_AddProxy.Click += new System.EventHandler(this.Btn_doProxy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // Tb_User
            // 
            this.Tb_User.Location = new System.Drawing.Point(103, 99);
            this.Tb_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tb_User.Name = "Tb_User";
            this.Tb_User.Size = new System.Drawing.Size(249, 27);
            this.Tb_User.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // Lb_Proxies
            // 
            this.Lb_Proxies.FormattingEnabled = true;
            this.Lb_Proxies.ItemHeight = 20;
            this.Lb_Proxies.Location = new System.Drawing.Point(36, 34);
            this.Lb_Proxies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lb_Proxies.Name = "Lb_Proxies";
            this.Lb_Proxies.Size = new System.Drawing.Size(522, 704);
            this.Lb_Proxies.TabIndex = 0;
            this.Lb_Proxies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lb_proxies_KeyDown);
            // 
            // ProxiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lb_Proxies);
            this.Name = "ProxiesControl";
            this.Size = new System.Drawing.Size(1234, 799);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox Tb_Ip;
        private Button btn_Run;
        private TextBox Tb_Password;
        private Label label3;
        private Button btn_AddProxy;
        private Label label2;
        private TextBox Tb_User;
        private Label label1;
        private ListBox Lb_Proxies;
    }
}
