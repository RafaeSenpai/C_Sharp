namespace GeradorDeSenhasV2
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
            this.chkbox_maiusculas = new System.Windows.Forms.CheckBox();
            this.chkbox_simbolos = new System.Windows.Forms.CheckBox();
            this.chkbox_algarismos = new System.Windows.Forms.CheckBox();
            this.num_Caracteres = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_gerarSenhas = new System.Windows.Forms.Button();
            this.lst_senhas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Caracteres)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbox_maiusculas
            // 
            this.chkbox_maiusculas.AutoSize = true;
            this.chkbox_maiusculas.Location = new System.Drawing.Point(276, 96);
            this.chkbox_maiusculas.Name = "chkbox_maiusculas";
            this.chkbox_maiusculas.Size = new System.Drawing.Size(134, 21);
            this.chkbox_maiusculas.TabIndex = 1;
            this.chkbox_maiusculas.Text = "Usar Maiusculas";
            this.chkbox_maiusculas.UseVisualStyleBackColor = true;
            // 
            // chkbox_simbolos
            // 
            this.chkbox_simbolos.AutoSize = true;
            this.chkbox_simbolos.Location = new System.Drawing.Point(276, 172);
            this.chkbox_simbolos.Name = "chkbox_simbolos";
            this.chkbox_simbolos.Size = new System.Drawing.Size(121, 21);
            this.chkbox_simbolos.TabIndex = 2;
            this.chkbox_simbolos.Text = "Usar Simbolos";
            this.chkbox_simbolos.UseVisualStyleBackColor = true;
            // 
            // chkbox_algarismos
            // 
            this.chkbox_algarismos.AutoSize = true;
            this.chkbox_algarismos.Location = new System.Drawing.Point(276, 134);
            this.chkbox_algarismos.Name = "chkbox_algarismos";
            this.chkbox_algarismos.Size = new System.Drawing.Size(133, 21);
            this.chkbox_algarismos.TabIndex = 3;
            this.chkbox_algarismos.Text = "Usar Algarismos";
            this.chkbox_algarismos.UseVisualStyleBackColor = true;
            // 
            // num_Caracteres
            // 
            this.num_Caracteres.Location = new System.Drawing.Point(276, 61);
            this.num_Caracteres.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_Caracteres.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_Caracteres.Name = "num_Caracteres";
            this.num_Caracteres.Size = new System.Drawing.Size(120, 22);
            this.num_Caracteres.TabIndex = 4;
            this.num_Caracteres.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senhas geradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de Caracteres";
            // 
            // cmd_gerarSenhas
            // 
            this.cmd_gerarSenhas.Location = new System.Drawing.Point(276, 212);
            this.cmd_gerarSenhas.Name = "cmd_gerarSenhas";
            this.cmd_gerarSenhas.Size = new System.Drawing.Size(121, 38);
            this.cmd_gerarSenhas.TabIndex = 7;
            this.cmd_gerarSenhas.Text = "Gerar Senhas";
            this.cmd_gerarSenhas.UseVisualStyleBackColor = true;
            this.cmd_gerarSenhas.Click += new System.EventHandler(this.cmd_gerarSenhas_Click);
            // 
            // lst_senhas
            // 
            this.lst_senhas.FormattingEnabled = true;
            this.lst_senhas.ItemHeight = 16;
            this.lst_senhas.Location = new System.Drawing.Point(26, 34);
            this.lst_senhas.Name = "lst_senhas";
            this.lst_senhas.Size = new System.Drawing.Size(223, 228);
            this.lst_senhas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.lst_senhas);
            this.Controls.Add(this.cmd_gerarSenhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_Caracteres);
            this.Controls.Add(this.chkbox_algarismos);
            this.Controls.Add(this.chkbox_simbolos);
            this.Controls.Add(this.chkbox_maiusculas);
            this.Name = "Form1";
            this.Text = "Gerador de senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Caracteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkbox_maiusculas;
        private System.Windows.Forms.CheckBox chkbox_simbolos;
        private System.Windows.Forms.CheckBox chkbox_algarismos;
        private System.Windows.Forms.NumericUpDown num_Caracteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_gerarSenhas;
        private System.Windows.Forms.ListBox lst_senhas;
    }
}

