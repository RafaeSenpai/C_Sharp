namespace WindowsFormsApp1
{
    partial class Form_Maquina
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtb_val1 = new System.Windows.Forms.TextBox();
            this.txtb_val2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.cmd_soma = new System.Windows.Forms.Button();
            this.cmd_divisao = new System.Windows.Forms.Button();
            this.cmd_multiplicacao = new System.Windows.Forms.Button();
            this.cmd_subtracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_val1
            // 
            this.txtb_val1.Location = new System.Drawing.Point(52, 24);
            this.txtb_val1.Name = "txtb_val1";
            this.txtb_val1.Size = new System.Drawing.Size(190, 22);
            this.txtb_val1.TabIndex = 0;
            // 
            // txtb_val2
            // 
            this.txtb_val2.Location = new System.Drawing.Point(52, 52);
            this.txtb_val2.Name = "txtb_val2";
            this.txtb_val2.Size = new System.Drawing.Size(190, 22);
            this.txtb_val2.TabIndex = 1;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(52, 81);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 17);
            this.lbl_resultado.TabIndex = 2;
            // 
            // cmd_soma
            // 
            this.cmd_soma.Enabled = false;
            this.cmd_soma.Location = new System.Drawing.Point(52, 116);
            this.cmd_soma.Name = "cmd_soma";
            this.cmd_soma.Size = new System.Drawing.Size(43, 23);
            this.cmd_soma.TabIndex = 6;
            this.cmd_soma.Text = "+";
            this.cmd_soma.UseVisualStyleBackColor = true;
            this.cmd_soma.Click += new System.EventHandler(this.minha_operacao_clik);
            // 
            // cmd_divisao
            // 
            this.cmd_divisao.Enabled = false;
            this.cmd_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_divisao.Location = new System.Drawing.Point(199, 117);
            this.cmd_divisao.Name = "cmd_divisao";
            this.cmd_divisao.Size = new System.Drawing.Size(43, 23);
            this.cmd_divisao.TabIndex = 7;
            this.cmd_divisao.Text = ":";
            this.cmd_divisao.UseVisualStyleBackColor = true;
            this.cmd_divisao.Click += new System.EventHandler(this.minha_operacao_clik);
            // 
            // cmd_multiplicacao
            // 
            this.cmd_multiplicacao.Enabled = false;
            this.cmd_multiplicacao.Location = new System.Drawing.Point(150, 117);
            this.cmd_multiplicacao.Name = "cmd_multiplicacao";
            this.cmd_multiplicacao.Size = new System.Drawing.Size(43, 23);
            this.cmd_multiplicacao.TabIndex = 8;
            this.cmd_multiplicacao.Text = "X";
            this.cmd_multiplicacao.UseVisualStyleBackColor = true;
            this.cmd_multiplicacao.Click += new System.EventHandler(this.minha_operacao_clik);
            // 
            // cmd_subtracao
            // 
            this.cmd_subtracao.Enabled = false;
            this.cmd_subtracao.Location = new System.Drawing.Point(101, 116);
            this.cmd_subtracao.Name = "cmd_subtracao";
            this.cmd_subtracao.Size = new System.Drawing.Size(43, 23);
            this.cmd_subtracao.TabIndex = 9;
            this.cmd_subtracao.Text = "-";
            this.cmd_subtracao.UseVisualStyleBackColor = true;
            this.cmd_subtracao.Click += new System.EventHandler(this.minha_operacao_clik);
            // 
            // Form_Maquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 151);
            this.Controls.Add(this.cmd_subtracao);
            this.Controls.Add(this.cmd_multiplicacao);
            this.Controls.Add(this.cmd_divisao);
            this.Controls.Add(this.cmd_soma);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txtb_val2);
            this.Controls.Add(this.txtb_val1);
            this.Name = "Form_Maquina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Básica";
            this.Load += new System.EventHandler(this.Form_Maquina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_val1;
        private System.Windows.Forms.TextBox txtb_val2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button cmd_soma;
        private System.Windows.Forms.Button cmd_divisao;
        private System.Windows.Forms.Button cmd_multiplicacao;
        private System.Windows.Forms.Button cmd_subtracao;
    }
}

