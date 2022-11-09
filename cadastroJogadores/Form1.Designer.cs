namespace cadastroJogadores
{
    partial class Form_Principal
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
            this.titulo = new System.Windows.Forms.Label();
            this.button_trocar = new System.Windows.Forms.Button();
            this.label1_nomejogador = new System.Windows.Forms.Label();
            this.textBox1_Namejogador = new System.Windows.Forms.TextBox();
            this.button1_limapar = new System.Windows.Forms.Button();
            this.textBox1_listasNomes = new System.Windows.Forms.TextBox();
            this.button1_Inserir = new System.Windows.Forms.Button();
            this.label1_TotalNomes = new System.Windows.Forms.Label();
            this.button1_deletarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(214, 15);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Turma de Programação .Net Atos e Ufn";
            // 
            // button_trocar
            // 
            this.button_trocar.Location = new System.Drawing.Point(12, 27);
            this.button_trocar.Name = "button_trocar";
            this.button_trocar.Size = new System.Drawing.Size(214, 37);
            this.button_trocar.TabIndex = 1;
            this.button_trocar.Text = "Trocar texto do titulo";
            this.button_trocar.UseVisualStyleBackColor = true;
            this.button_trocar.Click += new System.EventHandler(this.button_trocar_Click);
            // 
            // label1_nomejogador
            // 
            this.label1_nomejogador.AutoSize = true;
            this.label1_nomejogador.Location = new System.Drawing.Point(47, 190);
            this.label1_nomejogador.Name = "label1_nomejogador";
            this.label1_nomejogador.Size = new System.Drawing.Size(84, 15);
            this.label1_nomejogador.TabIndex = 2;
            this.label1_nomejogador.Text = "Nome jogador";
            // 
            // textBox1_Namejogador
            // 
            this.textBox1_Namejogador.Location = new System.Drawing.Point(137, 192);
            this.textBox1_Namejogador.Name = "textBox1_Namejogador";
            this.textBox1_Namejogador.Size = new System.Drawing.Size(397, 23);
            this.textBox1_Namejogador.TabIndex = 3;
            // 
            // button1_limapar
            // 
            this.button1_limapar.Location = new System.Drawing.Point(382, 240);
            this.button1_limapar.Name = "button1_limapar";
            this.button1_limapar.Size = new System.Drawing.Size(152, 23);
            this.button1_limapar.TabIndex = 5;
            this.button1_limapar.Text = "Limpar";
            this.button1_limapar.UseVisualStyleBackColor = true;
            this.button1_limapar.Click += new System.EventHandler(this.button1_limapar_Click);
            // 
            // textBox1_listasNomes
            // 
            this.textBox1_listasNomes.Location = new System.Drawing.Point(582, 141);
            this.textBox1_listasNomes.Multiline = true;
            this.textBox1_listasNomes.Name = "textBox1_listasNomes";
            this.textBox1_listasNomes.ReadOnly = true;
            this.textBox1_listasNomes.Size = new System.Drawing.Size(173, 227);
            this.textBox1_listasNomes.TabIndex = 6;
            // 
            // button1_Inserir
            // 
            this.button1_Inserir.Location = new System.Drawing.Point(137, 240);
            this.button1_Inserir.Name = "button1_Inserir";
            this.button1_Inserir.Size = new System.Drawing.Size(143, 23);
            this.button1_Inserir.TabIndex = 7;
            this.button1_Inserir.Text = "Inserir Name";
            this.button1_Inserir.UseVisualStyleBackColor = true;
            this.button1_Inserir.Click += new System.EventHandler(this.button1_Inserir_Click);
            // 
            // label1_TotalNomes
            // 
            this.label1_TotalNomes.AutoSize = true;
            this.label1_TotalNomes.Location = new System.Drawing.Point(535, 353);
            this.label1_TotalNomes.Name = "label1_TotalNomes";
            this.label1_TotalNomes.Size = new System.Drawing.Size(41, 15);
            this.label1_TotalNomes.TabIndex = 8;
            this.label1_TotalNomes.Text = "Total 0";
            // 
            // button1_deletarArquivo
            // 
            this.button1_deletarArquivo.Location = new System.Drawing.Point(137, 296);
            this.button1_deletarArquivo.Name = "button1_deletarArquivo";
            this.button1_deletarArquivo.Size = new System.Drawing.Size(143, 23);
            this.button1_deletarArquivo.TabIndex = 9;
            this.button1_deletarArquivo.Text = "Deleta Arquivo";
            this.button1_deletarArquivo.UseVisualStyleBackColor = true;
            this.button1_deletarArquivo.Click += new System.EventHandler(this.button1_deletarArquivo_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_deletarArquivo);
            this.Controls.Add(this.label1_TotalNomes);
            this.Controls.Add(this.button1_Inserir);
            this.Controls.Add(this.textBox1_listasNomes);
            this.Controls.Add(this.button1_limapar);
            this.Controls.Add(this.textBox1_Namejogador);
            this.Controls.Add(this.label1_nomejogador);
            this.Controls.Add(this.button_trocar);
            this.Controls.Add(this.titulo);
            this.Name = "Form_Principal";
            this.Text = "Formulario Desktop Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titulo;
        private Button button_trocar;
        private Label label1_nomejogador;
        private TextBox textBox1_Namejogador;
        private Button button1_limapar;
        private TextBox textBox1_listasNomes;
        private Button button1_Inserir;
        private Label label1_TotalNomes;
        private Button button1_deletarArquivo;
    }
}