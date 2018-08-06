namespace D2CalculadorBasica
{
    partial class FormDaCalculadora
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
            this.txtbox_val1 = new System.Windows.Forms.TextBox();
            this.txtbox_val2 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_calcula = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_val1
            // 
            this.txtbox_val1.Location = new System.Drawing.Point(53, 12);
            this.txtbox_val1.Name = "txtbox_val1";
            this.txtbox_val1.Size = new System.Drawing.Size(195, 22);
            this.txtbox_val1.TabIndex = 0;
            // 
            // txtbox_val2
            // 
            this.txtbox_val2.Location = new System.Drawing.Point(53, 40);
            this.txtbox_val2.Name = "txtbox_val2";
            this.txtbox_val2.Size = new System.Drawing.Size(195, 22);
            this.txtbox_val2.TabIndex = 1;
            // 
            // btn_soma
            // 
            this.btn_soma.Enabled = false;
            this.btn_soma.Location = new System.Drawing.Point(122, 129);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(39, 23);
            this.btn_soma.TabIndex = 2;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Enabled = false;
            this.btn_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisao.Location = new System.Drawing.Point(122, 158);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(39, 23);
            this.btn_divisao.TabIndex = 6;
            this.btn_divisao.Text = ":";
            this.btn_divisao.UseVisualStyleBackColor = true;
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Enabled = false;
            this.btn_multiplicacao.Location = new System.Drawing.Point(212, 129);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(39, 23);
            this.btn_multiplicacao.TabIndex = 7;
            this.btn_multiplicacao.Text = "x";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Enabled = false;
            this.btn_subtracao.Location = new System.Drawing.Point(167, 129);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(39, 23);
            this.btn_subtracao.TabIndex = 8;
            this.btn_subtracao.Text = "-";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_calcula
            // 
            this.btn_calcula.Enabled = false;
            this.btn_calcula.Location = new System.Drawing.Point(167, 158);
            this.btn_calcula.Name = "btn_calcula";
            this.btn_calcula.Size = new System.Drawing.Size(84, 23);
            this.btn_calcula.TabIndex = 9;
            this.btn_calcula.Text = "=";
            this.btn_calcula.UseVisualStyleBackColor = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(50, 82);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(72, 17);
            this.lbl_result.TabIndex = 10;
            this.lbl_result.Text = "Resultado";
            this.lbl_result.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(53, 129);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(53, 52);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "C";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // FormDaCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 204);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_calcula);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txtbox_val2);
            this.Controls.Add(this.txtbox_val1);
            this.MinimumSize = new System.Drawing.Size(310, 251);
            this.Name = "FormDaCalculadora";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_val1;
        private System.Windows.Forms.TextBox txtbox_val2;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_calcula;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_limpar;
    }
}

