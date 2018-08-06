namespace CalculadoraV2
{
    partial class Form1
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.cmd_soma = new System.Windows.Forms.Button();
            this.cmd_divisao = new System.Windows.Forms.Button();
            this.cmd_multiplicacao = new System.Windows.Forms.Button();
            this.cmd_subtracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_val1
            // 
            this.txtb_val1.Location = new System.Drawing.Point(53, 29);
            this.txtb_val1.Name = "txtb_val1";
            this.txtb_val1.Size = new System.Drawing.Size(100, 22);
            this.txtb_val1.TabIndex = 0;
            // 
            // txtb_val2
            // 
            this.txtb_val2.Location = new System.Drawing.Point(53, 71);
            this.txtb_val2.Name = "txtb_val2";
            this.txtb_val2.Size = new System.Drawing.Size(100, 22);
            this.txtb_val2.TabIndex = 1;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(53, 110);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(46, 17);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "label1";
            // 
            // cmd_soma
            // 
            this.cmd_soma.Location = new System.Drawing.Point(56, 140);
            this.cmd_soma.Name = "cmd_soma";
            this.cmd_soma.Size = new System.Drawing.Size(75, 23);
            this.cmd_soma.TabIndex = 3;
            this.cmd_soma.Text = "+";
            this.cmd_soma.UseVisualStyleBackColor = true;
            this.cmd_soma.Click += new System.EventHandler(this.operacao_click);
            // 
            // cmd_divisao
            // 
            this.cmd_divisao.Location = new System.Drawing.Point(148, 169);
            this.cmd_divisao.Name = "cmd_divisao";
            this.cmd_divisao.Size = new System.Drawing.Size(75, 23);
            this.cmd_divisao.TabIndex = 4;
            this.cmd_divisao.Text = "/";
            this.cmd_divisao.UseVisualStyleBackColor = true;
            this.cmd_divisao.Click += new System.EventHandler(this.operacao_click);
            // 
            // cmd_multiplicacao
            // 
            this.cmd_multiplicacao.Location = new System.Drawing.Point(56, 169);
            this.cmd_multiplicacao.Name = "cmd_multiplicacao";
            this.cmd_multiplicacao.Size = new System.Drawing.Size(75, 23);
            this.cmd_multiplicacao.TabIndex = 5;
            this.cmd_multiplicacao.Text = "x";
            this.cmd_multiplicacao.UseVisualStyleBackColor = true;
            this.cmd_multiplicacao.Click += new System.EventHandler(this.operacao_click);
            // 
            // cmd_subtracao
            // 
            this.cmd_subtracao.Location = new System.Drawing.Point(148, 140);
            this.cmd_subtracao.Name = "cmd_subtracao";
            this.cmd_subtracao.Size = new System.Drawing.Size(75, 23);
            this.cmd_subtracao.TabIndex = 6;
            this.cmd_subtracao.Text = "-";
            this.cmd_subtracao.UseVisualStyleBackColor = true;
            this.cmd_subtracao.Click += new System.EventHandler(this.operacao_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 230);
            this.Controls.Add(this.cmd_subtracao);
            this.Controls.Add(this.cmd_multiplicacao);
            this.Controls.Add(this.cmd_divisao);
            this.Controls.Add(this.cmd_soma);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txtb_val2);
            this.Controls.Add(this.txtb_val1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_val1;
        private System.Windows.Forms.TextBox txtb_val2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button cmd_soma;
        private System.Windows.Forms.Button cmd_divisao;
        private System.Windows.Forms.Button cmd_multiplicacao;
        private System.Windows.Forms.Button cmd_subtracao;
    }
}

