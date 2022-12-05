namespace CadastroGlicemia
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idMedida = new System.Windows.Forms.ColumnHeader();
            this.ValorGlicêmico = new System.Windows.Forms.ColumnHeader();
            this.Datamedição = new System.Windows.Forms.ColumnHeader();
            this.Paciente = new System.Windows.Forms.ColumnHeader();
            this.idPaciente = new System.Windows.Forms.ColumnHeader();
            this.ConectarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_idMedidaGlicemia = new System.Windows.Forms.TextBox();
            this.textBox2_valorGlicemia = new System.Windows.Forms.TextBox();
            this.textBox3_dataMedida = new System.Windows.Forms.TextBox();
            this.textBox4_idPaciente = new System.Windows.Forms.TextBox();
            this.button1_cadastrar = new System.Windows.Forms.Button();
            this.Button_Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idMedida,
            this.ValorGlicêmico,
            this.Datamedição,
            this.Paciente,
            this.idPaciente});
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.Location = new System.Drawing.Point(98, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 139);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idMedida
            // 
            this.idMedida.Tag = "idMedida";
            this.idMedida.Text = "idMedida";
            this.idMedida.Width = 100;
            // 
            // ValorGlicêmico
            // 
            this.ValorGlicêmico.Tag = "Valor Glicêmico";
            this.ValorGlicêmico.Text = "Valor Glicêmico";
            this.ValorGlicêmico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValorGlicêmico.Width = 100;
            // 
            // Datamedição
            // 
            this.Datamedição.Tag = "Data medição";
            this.Datamedição.Text = "Data medição";
            this.Datamedição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Datamedição.Width = 100;
            // 
            // Paciente
            // 
            this.Paciente.Tag = "Paciente";
            this.Paciente.Text = "Paciente";
            this.Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Paciente.Width = 100;
            // 
            // idPaciente
            // 
            this.idPaciente.Tag = "idPaciente";
            this.idPaciente.Text = "idPaciente";
            this.idPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idPaciente.Width = 100;
            // 
            // ConectarButton
            // 
            this.ConectarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConectarButton.Location = new System.Drawing.Point(98, 172);
            this.ConectarButton.Name = "ConectarButton";
            this.ConectarButton.Size = new System.Drawing.Size(134, 23);
            this.ConectarButton.TabIndex = 1;
            this.ConectarButton.Text = "Conectar";
            this.ConectarButton.UseVisualStyleBackColor = false;
            this.ConectarButton.Click += new System.EventHandler(this.ConectarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "idMedidaGlicemia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "valorGlicemia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "dataMedida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "idPaciente";
            // 
            // textBox1_idMedidaGlicemia
            // 
            this.textBox1_idMedidaGlicemia.Location = new System.Drawing.Point(222, 244);
            this.textBox1_idMedidaGlicemia.Name = "textBox1_idMedidaGlicemia";
            this.textBox1_idMedidaGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBox1_idMedidaGlicemia.TabIndex = 6;
            // 
            // textBox2_valorGlicemia
            // 
            this.textBox2_valorGlicemia.Location = new System.Drawing.Point(222, 277);
            this.textBox2_valorGlicemia.Name = "textBox2_valorGlicemia";
            this.textBox2_valorGlicemia.Size = new System.Drawing.Size(100, 23);
            this.textBox2_valorGlicemia.TabIndex = 7;
            // 
            // textBox3_dataMedida
            // 
            this.textBox3_dataMedida.Location = new System.Drawing.Point(222, 306);
            this.textBox3_dataMedida.Name = "textBox3_dataMedida";
            this.textBox3_dataMedida.Size = new System.Drawing.Size(100, 23);
            this.textBox3_dataMedida.TabIndex = 8;
            // 
            // textBox4_idPaciente
            // 
            this.textBox4_idPaciente.Location = new System.Drawing.Point(222, 335);
            this.textBox4_idPaciente.Name = "textBox4_idPaciente";
            this.textBox4_idPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBox4_idPaciente.TabIndex = 9;
            // 
            // button1_cadastrar
            // 
            this.button1_cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_cadastrar.Location = new System.Drawing.Point(247, 172);
            this.button1_cadastrar.Name = "button1_cadastrar";
            this.button1_cadastrar.Size = new System.Drawing.Size(168, 23);
            this.button1_cadastrar.TabIndex = 10;
            this.button1_cadastrar.Text = "Cadastrar";
            this.button1_cadastrar.UseVisualStyleBackColor = false;
            this.button1_cadastrar.Click += new System.EventHandler(this.button1_cadastrar_Click);
            // 
            // Button_Remover
            // 
            this.Button_Remover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Remover.Location = new System.Drawing.Point(434, 172);
            this.Button_Remover.Name = "Button_Remover";
            this.Button_Remover.Size = new System.Drawing.Size(165, 23);
            this.Button_Remover.TabIndex = 11;
            this.Button_Remover.Text = "Remover";
            this.Button_Remover.UseVisualStyleBackColor = false;
            this.Button_Remover.Click += new System.EventHandler(this.Button_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Remover);
            this.Controls.Add(this.button1_cadastrar);
            this.Controls.Add(this.textBox4_idPaciente);
            this.Controls.Add(this.textBox3_dataMedida);
            this.Controls.Add(this.textBox2_valorGlicemia);
            this.Controls.Add(this.textBox1_idMedidaGlicemia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConectarButton);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader idMedida;
        private ColumnHeader ValorGlicêmico;
        private ColumnHeader Datamedição;
        private ColumnHeader Paciente;
        private ColumnHeader idPaciente;
        private Button button1_Conectar;
        private Button ConectarButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1_idMedidaGlicemia;
        private TextBox textBox2_valorGlicemia;
        private TextBox textBox3_dataMedida;
        private TextBox textBox4_idPaciente;
        private Button button1_cadastrar;
        private Button Button_Remover;
    }
}