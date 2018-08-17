namespace soAlgarismosVSsoLetrasV2
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
            this.txt_algarismos = new System.Windows.Forms.TextBox();
            this.txt_letras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_algarismos
            // 
            this.txt_algarismos.Location = new System.Drawing.Point(15, 29);
            this.txt_algarismos.Name = "txt_algarismos";
            this.txt_algarismos.Size = new System.Drawing.Size(100, 22);
            this.txt_algarismos.TabIndex = 0;
            this.txt_algarismos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_algarismos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_algarismos_KeyPress);
            // 
            // txt_letras
            // 
            this.txt_letras.Location = new System.Drawing.Point(15, 84);
            this.txt_letras.Name = "txt_letras";
            this.txt_letras.Size = new System.Drawing.Size(100, 22);
            this.txt_letras.TabIndex = 1;
            this.txt_letras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_letras_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Só algarismos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Só Letras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_letras);
            this.Controls.Add(this.txt_algarismos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_algarismos;
        private System.Windows.Forms.TextBox txt_letras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

