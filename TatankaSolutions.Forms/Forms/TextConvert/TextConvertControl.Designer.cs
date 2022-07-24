namespace TatankaSolutions.Forms
{
    partial class TextConvertControl
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
            this.Btn_Lado = new System.Windows.Forms.Button();
            this.Btn_Baixo = new System.Windows.Forms.Button();
            this.Tb_Saida = new System.Windows.Forms.TextBox();
            this.Tb_Entrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Lado
            // 
            this.Btn_Lado.Location = new System.Drawing.Point(581, 135);
            this.Btn_Lado.Name = "Btn_Lado";
            this.Btn_Lado.Size = new System.Drawing.Size(94, 29);
            this.Btn_Lado.TabIndex = 2;
            this.Btn_Lado.Text = "Lado";
            this.Btn_Lado.UseVisualStyleBackColor = true;
            this.Btn_Lado.Click += new System.EventHandler(this.Btn_Lado_Click);
            // 
            // Btn_Baixo
            // 
            this.Btn_Baixo.Location = new System.Drawing.Point(581, 51);
            this.Btn_Baixo.Name = "Btn_Baixo";
            this.Btn_Baixo.Size = new System.Drawing.Size(94, 29);
            this.Btn_Baixo.TabIndex = 1;
            this.Btn_Baixo.Text = "Baixo";
            this.Btn_Baixo.UseVisualStyleBackColor = true;
            this.Btn_Baixo.Click += new System.EventHandler(this.Btn_Baixo_Click);
            // 
            // Tb_Saida
            // 
            this.Tb_Saida.Location = new System.Drawing.Point(702, 40);
            this.Tb_Saida.Multiline = true;
            this.Tb_Saida.Name = "Tb_Saida";
            this.Tb_Saida.ReadOnly = true;
            this.Tb_Saida.Size = new System.Drawing.Size(604, 713);
            this.Tb_Saida.TabIndex = 3;
            // 
            // Tb_Entrada
            // 
            this.Tb_Entrada.Location = new System.Drawing.Point(45, 41);
            this.Tb_Entrada.Multiline = true;
            this.Tb_Entrada.Name = "Tb_Entrada";
            this.Tb_Entrada.Size = new System.Drawing.Size(510, 712);
            this.Tb_Entrada.TabIndex = 0;
            // 
            // TextConvertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Lado);
            this.Controls.Add(this.Btn_Baixo);
            this.Controls.Add(this.Tb_Saida);
            this.Controls.Add(this.Tb_Entrada);
            this.Name = "TextConvertControl";
            this.Size = new System.Drawing.Size(1365, 802);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Lado;
        private Button Btn_Baixo;
        private TextBox Tb_Saida;
        private TextBox Tb_Entrada;
    }
}
