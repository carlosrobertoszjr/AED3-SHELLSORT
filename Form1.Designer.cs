namespace shellsort_project
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
            this.label1 = new System.Windows.Forms.Label();
            //this.btGravar = new System.Windows.Forms.Button();
            this.inputPalavra = new System.Windows.Forms.RichTextBox();
            this.rbtnSsort = new System.Windows.Forms.RadioButton();
            this.rbtnBubble = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.Label();
            this.outputTempo = new System.Windows.Forms.TextBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma opção:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btGravar
            // 
            //this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //this.btGravar.Location = new System.Drawing.Point(196, 72);
            //this.btGravar.Name = "btGravar";
            //this.btGravar.Size = new System.Drawing.Size(75, 29);
            //this.btGravar.TabIndex = 1;
            //this.btGravar.Text = "Verificar";
            //this.btGravar.UseVisualStyleBackColor = true;
            //this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // inputPalavra
            // 
            this.inputPalavra.Location = new System.Drawing.Point(33, 76);
            this.inputPalavra.Name = "inputPalavra";
            this.inputPalavra.ShowSelectionMargin = true;
            this.inputPalavra.Size = new System.Drawing.Size(157, 29);
            this.inputPalavra.TabIndex = 2;
            this.inputPalavra.Text = "";
            this.inputPalavra.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rbtnSsort
            // 
            this.rbtnSsort.AutoSize = true;
            this.rbtnSsort.Location = new System.Drawing.Point(33, 51);
            this.rbtnSsort.Name = "rbtnSsort";
            this.rbtnSsort.Size = new System.Drawing.Size(74, 19);
            this.rbtnSsort.TabIndex = 3;
            this.rbtnSsort.TabStop = true;
            this.rbtnSsort.Text = "Shell Sort";
            this.rbtnSsort.UseVisualStyleBackColor = true;
            this.rbtnSsort.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnBubble
            // 
            this.rbtnBubble.AutoSize = true;
            this.rbtnBubble.Location = new System.Drawing.Point(128, 51);
            this.rbtnBubble.Name = "rbtnBubble";
            this.rbtnBubble.Size = new System.Drawing.Size(62, 19);
            this.rbtnBubble.TabIndex = 4;
            this.rbtnBubble.TabStop = true;
            this.rbtnBubble.Text = "Bubble";
            this.rbtnBubble.UseVisualStyleBackColor = true;
            this.rbtnBubble.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // txtTempo
            // 
            this.txtTempo.AutoSize = true;
            this.txtTempo.BackColor = System.Drawing.Color.Transparent;
            this.txtTempo.Location = new System.Drawing.Point(16, 183);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(46, 15);
            this.txtTempo.TabIndex = 6;
            this.txtTempo.Text = "Tempo:";
            this.txtTempo.Click += new System.EventHandler(this.teste_Click_1);
            // 
            // outputTempo
            // 
            this.outputTempo.Location = new System.Drawing.Point(68, 180);
            this.outputTempo.Name = "outputTempo";
            this.outputTempo.ReadOnly = true;
            this.outputTempo.Size = new System.Drawing.Size(203, 23);
            this.outputTempo.TabIndex = 7;
            this.outputTempo.TextChanged += new System.EventHandler(this.outputTempo_TextChanged);
            // 
            // btFinalizar
            // 
            this.btFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFinalizar.Location = new System.Drawing.Point(33, 111);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(157, 29);
            this.btFinalizar.TabIndex = 8;
            this.btFinalizar.Text = "Finalizar operação";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 231);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.outputTempo);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnBubble);
            this.Controls.Add(this.rbtnSsort);
            this.Controls.Add(this.inputPalavra);
            //this.Controls.Add(this.btGravar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AED 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        //private Button btGravar;
        private RichTextBox inputPalavra;
        private RadioButton rbtnSsort;
        private RadioButton rbtnBubble;
        private Label label2;
        private Label txtTempo;
        private TextBox outputTempo;
        private Button btFinalizar;
    }
}