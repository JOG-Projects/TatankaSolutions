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
            this.ip = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_doProxy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_proxies = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.ip);
            this.panel1.Controls.Add(this.btn_run);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_doProxy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(619, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 449);
            this.panel1.TabIndex = 11;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(103, 60);
            this.ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(249, 27);
            this.ip.TabIndex = 0;
            // 
            // btn_run
            // 
            this.btn_run.BackgroundImage = global::ConvertText.Properties.Resources.play_icon_134504;
            this.btn_run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_run.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_run.ForeColor = System.Drawing.Color.Yellow;
            this.btn_run.Location = new System.Drawing.Point(57, 176);
            this.btn_run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(414, 201);
            this.btn_run.TabIndex = 8;
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.Btn_run_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(103, 137);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(249, 27);
            this.password.TabIndex = 1;
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
            // btn_doProxy
            // 
            this.btn_doProxy.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_doProxy.BackgroundImage = global::ConvertText.Properties.Resources._7630ad49bdc79b8482c8627c663a1373;
            this.btn_doProxy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doProxy.Location = new System.Drawing.Point(371, 60);
            this.btn_doProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_doProxy.Name = "btn_doProxy";
            this.btn_doProxy.Size = new System.Drawing.Size(98, 108);
            this.btn_doProxy.TabIndex = 2;
            this.btn_doProxy.UseVisualStyleBackColor = false;
            this.btn_doProxy.Click += new System.EventHandler(this.Btn_doProxy_Click);
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
            // user
            // 
            this.user.Location = new System.Drawing.Point(103, 99);
            this.user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(249, 27);
            this.user.TabIndex = 3;
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
            // lb_proxies
            // 
            this.lb_proxies.FormattingEnabled = true;
            this.lb_proxies.ItemHeight = 20;
            this.lb_proxies.Location = new System.Drawing.Point(36, 34);
            this.lb_proxies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_proxies.Name = "lb_proxies";
            this.lb_proxies.Size = new System.Drawing.Size(522, 704);
            this.lb_proxies.TabIndex = 10;
            this.lb_proxies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lb_proxies_KeyDown);
            // 
            // ProxiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_proxies);
            this.Name = "ProxiesControl";
            this.Size = new System.Drawing.Size(1234, 799);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox ip;
        private Button btn_run;
        private TextBox password;
        private Label label3;
        private Button btn_doProxy;
        private Label label2;
        private TextBox user;
        private Label label1;
        private ListBox lb_proxies;
    }
}
