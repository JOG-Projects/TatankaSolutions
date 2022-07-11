namespace ConvertText
{
    partial class Form1
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
            this.Tb_Entrada = new System.Windows.Forms.TextBox();
            this.Tb_Saida = new System.Windows.Forms.TextBox();
            this.Btn_Baixo = new System.Windows.Forms.Button();
            this.Btn_Lado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_Entrada
            // 
            this.Tb_Entrada.Location = new System.Drawing.Point(32, 57);
            this.Tb_Entrada.Multiline = true;
            this.Tb_Entrada.Name = "Tb_Entrada";
            this.Tb_Entrada.Size = new System.Drawing.Size(510, 712);
            this.Tb_Entrada.TabIndex = 1;
            // 
            // Tb_Saida
            // 
            this.Tb_Saida.Location = new System.Drawing.Point(704, 56);
            this.Tb_Saida.Multiline = true;
            this.Tb_Saida.Name = "Tb_Saida";
            this.Tb_Saida.Size = new System.Drawing.Size(604, 713);
            this.Tb_Saida.TabIndex = 2;
            // 
            // Btn_Baixo
            // 
            this.Btn_Baixo.Location = new System.Drawing.Point(586, 56);
            this.Btn_Baixo.Name = "Btn_Baixo";
            this.Btn_Baixo.Size = new System.Drawing.Size(94, 29);
            this.Btn_Baixo.TabIndex = 3;
            this.Btn_Baixo.Text = "Baixo";
            this.Btn_Baixo.UseVisualStyleBackColor = true;
            this.Btn_Baixo.Click += new System.EventHandler(this.Btn_Baixo_Click);
            // 
            // Btn_Lado
            // 
            this.Btn_Lado.Location = new System.Drawing.Point(586, 140);
            this.Btn_Lado.Name = "Btn_Lado";
            this.Btn_Lado.Size = new System.Drawing.Size(94, 29);
            this.Btn_Lado.TabIndex = 4;
            this.Btn_Lado.Text = "Lado";
            this.Btn_Lado.UseVisualStyleBackColor = true;
            this.Btn_Lado.Click += new System.EventHandler(this.Btn_Lado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 792);
            this.Controls.Add(this.Btn_Lado);
            this.Controls.Add(this.Btn_Baixo);
            this.Controls.Add(this.Tb_Saida);
            this.Controls.Add(this.Tb_Entrada);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tb_Entrada;
        private TextBox Tb_Saida;
        private Button Btn_Baixo;
        private Button Btn_Lado;
    }
}