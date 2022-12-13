namespace WindowsFormBancoDados
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
            this.button1_salvar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txb_localizacaodpo = new System.Windows.Forms.TextBox();
            this.txb_OrcamentoDPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NomeEmpregado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_EmpregadoFuncao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2_EmpregadoData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_EmpregadoSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1_EmpregadoComissão = new System.Windows.Forms.TextBox();
            this.button1_SalvarEmpregado = new System.Windows.Forms.Button();
            this.textBox1_Gerente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1_idDepartamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_salvar
            // 
            this.button1_salvar.Location = new System.Drawing.Point(150, 199);
            this.button1_salvar.Name = "button1_salvar";
            this.button1_salvar.Size = new System.Drawing.Size(75, 23);
            this.button1_salvar.TabIndex = 0;
            this.button1_salvar.Text = "Salvar";
            this.button1_salvar.UseVisualStyleBackColor = true;
            this.button1_salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(125, 65);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // txb_localizacaodpo
            // 
            this.txb_localizacaodpo.Location = new System.Drawing.Point(125, 94);
            this.txb_localizacaodpo.Name = "txb_localizacaodpo";
            this.txb_localizacaodpo.Size = new System.Drawing.Size(100, 23);
            this.txb_localizacaodpo.TabIndex = 2;
            // 
            // txb_OrcamentoDPT
            // 
            this.txb_OrcamentoDPT.Location = new System.Drawing.Point(125, 134);
            this.txb_OrcamentoDPT.Name = "txb_OrcamentoDPT";
            this.txb_OrcamentoDPT.Size = new System.Drawing.Size(100, 23);
            this.txb_OrcamentoDPT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localização";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oraçamento";
            // 
            // textBox_NomeEmpregado
            // 
            this.textBox_NomeEmpregado.Location = new System.Drawing.Point(536, 65);
            this.textBox_NomeEmpregado.Name = "textBox_NomeEmpregado";
            this.textBox_NomeEmpregado.Size = new System.Drawing.Size(100, 23);
            this.textBox_NomeEmpregado.TabIndex = 7;
            this.textBox_NomeEmpregado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NomeEmpregado_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // textBox1_EmpregadoFuncao
            // 
            this.textBox1_EmpregadoFuncao.Location = new System.Drawing.Point(537, 126);
            this.textBox1_EmpregadoFuncao.Name = "textBox1_EmpregadoFuncao";
            this.textBox1_EmpregadoFuncao.Size = new System.Drawing.Size(100, 23);
            this.textBox1_EmpregadoFuncao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Função";
            // 
            // textBox2_EmpregadoData
            // 
            this.textBox2_EmpregadoData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2_EmpregadoData.Location = new System.Drawing.Point(537, 155);
            this.textBox2_EmpregadoData.Name = "textBox2_EmpregadoData";
            this.textBox2_EmpregadoData.PlaceholderText = "yyyy-mm-dd";
            this.textBox2_EmpregadoData.Size = new System.Drawing.Size(100, 23);
            this.textBox2_EmpregadoData.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Adimisão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salario";
            // 
            // textBox1_EmpregadoSalario
            // 
            this.textBox1_EmpregadoSalario.Location = new System.Drawing.Point(536, 235);
            this.textBox1_EmpregadoSalario.Name = "textBox1_EmpregadoSalario";
            this.textBox1_EmpregadoSalario.Size = new System.Drawing.Size(100, 23);
            this.textBox1_EmpregadoSalario.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Comissão";
            // 
            // textBox1_EmpregadoComissão
            // 
            this.textBox1_EmpregadoComissão.Location = new System.Drawing.Point(537, 282);
            this.textBox1_EmpregadoComissão.Name = "textBox1_EmpregadoComissão";
            this.textBox1_EmpregadoComissão.Size = new System.Drawing.Size(100, 23);
            this.textBox1_EmpregadoComissão.TabIndex = 16;
            // 
            // button1_SalvarEmpregado
            // 
            this.button1_SalvarEmpregado.Location = new System.Drawing.Point(562, 349);
            this.button1_SalvarEmpregado.Name = "button1_SalvarEmpregado";
            this.button1_SalvarEmpregado.Size = new System.Drawing.Size(75, 23);
            this.button1_SalvarEmpregado.TabIndex = 17;
            this.button1_SalvarEmpregado.Text = "Salvar";
            this.button1_SalvarEmpregado.UseVisualStyleBackColor = true;
            this.button1_SalvarEmpregado.Click += new System.EventHandler(this.button1_SalvarEmpregado_Click);
            // 
            // textBox1_Gerente
            // 
            this.textBox1_Gerente.Location = new System.Drawing.Point(537, 94);
            this.textBox1_Gerente.Name = "textBox1_Gerente";
            this.textBox1_Gerente.Size = new System.Drawing.Size(100, 23);
            this.textBox1_Gerente.TabIndex = 18;
            this.textBox1_Gerente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_Gerente_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Id Gerente";
            // 
            // textBox1_idDepartamento
            // 
            this.textBox1_idDepartamento.Location = new System.Drawing.Point(536, 199);
            this.textBox1_idDepartamento.Name = "textBox1_idDepartamento";
            this.textBox1_idDepartamento.Size = new System.Drawing.Size(100, 23);
            this.textBox1_idDepartamento.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "id Departamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1_idDepartamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1_Gerente);
            this.Controls.Add(this.button1_SalvarEmpregado);
            this.Controls.Add(this.textBox1_EmpregadoComissão);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1_EmpregadoSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2_EmpregadoData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_EmpregadoFuncao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_NomeEmpregado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_OrcamentoDPT);
            this.Controls.Add(this.txb_localizacaodpo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.button1_salvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_salvar;
        private TextBox txt_nome;
        private TextBox txb_localizacaodpo;
        private TextBox txb_OrcamentoDPT;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_NomeEmpregado;
        private Label label4;
        private TextBox textBox1_EmpregadoFuncao;
        private Label label5;
        private TextBox textBox2_EmpregadoData;
        private Label label6;
        private Label label7;
        private TextBox textBox1_EmpregadoSalario;
        private Label label8;
        private TextBox textBox1_EmpregadoComissão;
        private Button button1_SalvarEmpregado;
        private TextBox textBox1_Gerente;
        private Label label9;
        private TextBox textBox1_idDepartamento;
        private Label label10;
    }
}