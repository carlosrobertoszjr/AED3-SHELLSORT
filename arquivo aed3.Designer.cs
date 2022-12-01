namespace WindowsFormsApp1
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
            this.shell_sorte = new System.Windows.Forms.Button();
            this.bolha = new System.Windows.Forms.Button();
            this.input_palavra = new System.Windows.Forms.TextBox();
            this.salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shell_sorte
            // 
            this.shell_sorte.BackColor = System.Drawing.SystemColors.Control;
            this.shell_sorte.ForeColor = System.Drawing.SystemColors.Desktop;
            this.shell_sorte.Location = new System.Drawing.Point(373, 80);
            this.shell_sorte.Name = "shell_sorte";
            this.shell_sorte.Size = new System.Drawing.Size(75, 23);
            this.shell_sorte.TabIndex = 0;
            this.shell_sorte.Text = "Shell Sort";
            this.shell_sorte.UseVisualStyleBackColor = false;
            this.shell_sorte.Click += new System.EventHandler(this.button1_Click);
            // 
            // bolha
            // 
            this.bolha.Location = new System.Drawing.Point(373, 109);
            this.bolha.Name = "bolha";
            this.bolha.Size = new System.Drawing.Size(75, 23);
            this.bolha.TabIndex = 1;
            this.bolha.Text = "Bolha";
            this.bolha.UseVisualStyleBackColor = true;
            // 
            // input_palavra
            // 
            this.input_palavra.Location = new System.Drawing.Point(293, 150);
            this.input_palavra.Name = "input_palavra";
            this.input_palavra.Size = new System.Drawing.Size(231, 20);
            this.input_palavra.TabIndex = 2;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(530, 148);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 3;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha uma opção";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.input_palavra);
            this.Controls.Add(this.bolha);
            this.Controls.Add(this.shell_sorte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shell_sorte;
        private System.Windows.Forms.Button bolha;
        private System.Windows.Forms.TextBox input_palavra;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Label label1;
    }
}

