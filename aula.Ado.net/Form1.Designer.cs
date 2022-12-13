namespace aula.Ado.net
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
            this.textBox1_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_Peso = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Gravar = new System.Windows.Forms.Button();
            this.button2_Consultar = new System.Windows.Forms.Button();
            this.button3_Filtrar = new System.Windows.Forms.Button();
            this.textBox1_Filtro = new System.Windows.Forms.TextBox();
            this.button1_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBox1_nome
            // 
            this.textBox1_nome.Location = new System.Drawing.Point(72, 92);
            this.textBox1_nome.Name = "textBox1_nome";
            this.textBox1_nome.Size = new System.Drawing.Size(100, 23);
            this.textBox1_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso";
            // 
            // textBox2_Peso
            // 
            this.textBox2_Peso.Location = new System.Drawing.Point(72, 148);
            this.textBox2_Peso.Name = "textBox2_Peso";
            this.textBox2_Peso.Size = new System.Drawing.Size(100, 23);
            this.textBox2_Peso.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(431, 178);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_Gravar
            // 
            this.button_Gravar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Gravar.Location = new System.Drawing.Point(72, 200);
            this.button_Gravar.Name = "button_Gravar";
            this.button_Gravar.Size = new System.Drawing.Size(75, 23);
            this.button_Gravar.TabIndex = 5;
            this.button_Gravar.Text = "Gravar";
            this.button_Gravar.UseVisualStyleBackColor = false;
            this.button_Gravar.Click += new System.EventHandler(this.button_Gravar_Click);
            // 
            // button2_Consultar
            // 
            this.button2_Consultar.BackColor = System.Drawing.Color.Red;
            this.button2_Consultar.Location = new System.Drawing.Point(452, 75);
            this.button2_Consultar.Name = "button2_Consultar";
            this.button2_Consultar.Size = new System.Drawing.Size(75, 23);
            this.button2_Consultar.TabIndex = 6;
            this.button2_Consultar.Text = "Consultar";
            this.button2_Consultar.UseVisualStyleBackColor = false;
            this.button2_Consultar.Click += new System.EventHandler(this.button2_Consultar_Click);
            // 
            // button3_Filtrar
            // 
            this.button3_Filtrar.BackColor = System.Drawing.Color.Lime;
            this.button3_Filtrar.Location = new System.Drawing.Point(561, 75);
            this.button3_Filtrar.Name = "button3_Filtrar";
            this.button3_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.button3_Filtrar.TabIndex = 7;
            this.button3_Filtrar.Text = "Filtrar";
            this.button3_Filtrar.UseVisualStyleBackColor = false;
            this.button3_Filtrar.Click += new System.EventHandler(this.button3_Filtrar_Click);
            // 
            // textBox1_Filtro
            // 
            this.textBox1_Filtro.Location = new System.Drawing.Point(561, 46);
            this.textBox1_Filtro.Name = "textBox1_Filtro";
            this.textBox1_Filtro.Size = new System.Drawing.Size(197, 23);
            this.textBox1_Filtro.TabIndex = 8;
            this.textBox1_Filtro.TextChanged += new System.EventHandler(this.textBox1_Filtro_TextChanged);
            // 
            // button1_Delete
            // 
            this.button1_Delete.BackColor = System.Drawing.Color.OrangeRed;
            this.button1_Delete.Location = new System.Drawing.Point(327, 332);
            this.button1_Delete.Name = "button1_Delete";
            this.button1_Delete.Size = new System.Drawing.Size(431, 23);
            this.button1_Delete.TabIndex = 9;
            this.button1_Delete.Text = "Deletar";
            this.button1_Delete.UseVisualStyleBackColor = false;
            this.button1_Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Delete);
            this.Controls.Add(this.textBox1_Filtro);
            this.Controls.Add(this.button3_Filtrar);
            this.Controls.Add(this.button2_Consultar);
            this.Controls.Add(this.button_Gravar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2_Peso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1_nome;
        private Label label2;
        private TextBox textBox2_Peso;
        private DataGridView dataGridView1;
        private Button button_Gravar;
        private Button button2_Consultar;
        private Button button3_Filtrar;
        private TextBox textBox1_Filtro;
        private Button button1_Delete;
    }
}