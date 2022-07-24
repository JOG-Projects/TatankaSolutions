namespace ConvertText
{
    partial class MainForm
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
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_Lado = new System.Windows.Forms.Button();
            this.Btn_Baixo = new System.Windows.Forms.Button();
            this.Tb_Saida = new System.Windows.Forms.TextBox();
            this.Tb_Entrada = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.TabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.tabPage1);
            this.TabPanel.Controls.Add(this.tabPage2);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Location = new System.Drawing.Point(0, 0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(1173, 594);
            this.TabPanel.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Lado);
            this.tabPage1.Controls.Add(this.Btn_Baixo);
            this.tabPage1.Controls.Add(this.Tb_Saida);
            this.tabPage1.Controls.Add(this.Tb_Entrada);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conversor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_Lado
            // 
            this.Btn_Lado.Location = new System.Drawing.Point(509, 78);
            this.Btn_Lado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Lado.Name = "Btn_Lado";
            this.Btn_Lado.Size = new System.Drawing.Size(82, 22);
            this.Btn_Lado.TabIndex = 8;
            this.Btn_Lado.Text = "Lado";
            this.Btn_Lado.UseVisualStyleBackColor = true;
            // 
            // Btn_Baixo
            // 
            this.Btn_Baixo.Location = new System.Drawing.Point(509, 15);
            this.Btn_Baixo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Baixo.Name = "Btn_Baixo";
            this.Btn_Baixo.Size = new System.Drawing.Size(82, 22);
            this.Btn_Baixo.TabIndex = 7;
            this.Btn_Baixo.Text = "Baixo";
            this.Btn_Baixo.UseVisualStyleBackColor = true;
            // 
            // Tb_Saida
            // 
            this.Tb_Saida.Location = new System.Drawing.Point(612, 15);
            this.Tb_Saida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_Saida.Multiline = true;
            this.Tb_Saida.Name = "Tb_Saida";
            this.Tb_Saida.Size = new System.Drawing.Size(529, 536);
            this.Tb_Saida.TabIndex = 6;
            // 
            // Tb_Entrada
            // 
            this.Tb_Entrada.Location = new System.Drawing.Point(24, 16);
            this.Tb_Entrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_Entrada.Multiline = true;
            this.Tb_Entrada.Name = "Tb_Entrada";
            this.Tb_Entrada.Size = new System.Drawing.Size(447, 535);
            this.Tb_Entrada.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lb_proxies);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proxy";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(609, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 337);
            this.panel1.TabIndex = 9;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(90, 45);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(218, 23);
            this.ip.TabIndex = 0;
            // 
            // btn_run
            // 
            this.btn_run.BackgroundImage = global::ConvertText.Properties.Resources.play_icon_134504;
            this.btn_run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_run.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_run.ForeColor = System.Drawing.Color.Yellow;
            this.btn_run.Location = new System.Drawing.Point(50, 132);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(362, 151);
            this.btn_run.TabIndex = 4;
            this.btn_run.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(90, 103);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 23);
            this.password.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "User:";
            // 
            // btn_doProxy
            // 
            this.btn_doProxy.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_doProxy.BackgroundImage = global::ConvertText.Properties.Resources._7630ad49bdc79b8482c8627c663a1373;
            this.btn_doProxy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_doProxy.Location = new System.Drawing.Point(325, 45);
            this.btn_doProxy.Name = "btn_doProxy";
            this.btn_doProxy.Size = new System.Drawing.Size(86, 81);
            this.btn_doProxy.TabIndex = 3;
            this.btn_doProxy.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(90, 74);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(218, 23);
            this.user.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // lb_proxies
            // 
            this.lb_proxies.FormattingEnabled = true;
            this.lb_proxies.ItemHeight = 15;
            this.lb_proxies.Location = new System.Drawing.Point(21, 15);
            this.lb_proxies.Name = "lb_proxies";
            this.lb_proxies.Size = new System.Drawing.Size(457, 529);
            this.lb_proxies.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 594);
            this.Controls.Add(this.TabPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.TabPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabPanel;
        private TabPage tabPage1;
        private Button Btn_Lado;
        private Button Btn_Baixo;
        private TextBox Tb_Saida;
        private TextBox Tb_Entrada;
        private TabPage tabPage2;
        private Button btn_doProxy;
        private TextBox password;
        private TextBox ip;
        private TextBox user;
        private ListBox lb_proxies;
        private Button btn_run;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}