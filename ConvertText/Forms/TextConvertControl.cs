﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertText.Forms
{
    public partial class TextConvertControl : UserControl
    {
        public TextConvertControl()
        {
            InitializeComponent();
        }
        private void Btn_Baixo_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = Tb_Entrada.Text;

                var linhas = entrada.Split("\n");

                var final = linhas.Select(l => l.Split(" "));

                Tb_Saida.Text = string.Join(Environment.NewLine, final.SelectMany(x => x));
            }
            catch { }
        }

        private void Btn_Lado_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = Tb_Entrada.Text;

                var palavras = new Queue<string>(entrada.Split("\n"));

                var sb = new StringBuilder();
                while (palavras.Any())
                {
                    var linha = $"{palavras.Dequeue().Trim()} {palavras.Dequeue().Trim()}";
                    sb.AppendLine(linha);
                }

                Tb_Saida.Text = sb.ToString();
            }
            catch { }
        }
    }
}
