using System.Windows.Forms;

namespace WindowsFormBancoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamento d = new Departamento(txt_nome.Text, txb_localizacaodpo.Text,txb_OrcamentoDPT.Text);
          
            if (d.gravarDepartamento())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Departamento!", "Erro!");


        }

        private void button1_SalvarEmpregado_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(textBox2_EmpregadoData.Text);
            var idGerente = Convert.ToInt32(textBox1_Gerente.Text);
            var salario = Convert.ToInt32(textBox1_EmpregadoSalario.Text);
            var comissao = Convert.ToInt32(textBox1_EmpregadoComissão.Text);
            var departamento = Convert.ToInt32(textBox1_idDepartamento.Text);

            Empregado empregado = new Empregado(textBox_NomeEmpregado.Text, idGerente,textBox1_EmpregadoFuncao.Text, departamento, data, salario, comissao);
           
            
              if (empregado.gravarEmpregado())
                MessageBox.Show("Salvo com sucesso!", "Atenção");
            else
                MessageBox.Show("Erro ao salvar Empregado!", "Erro!");
           

           

        }

        private void textBox1_Gerente_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_Gerente.MaxLength = 1;
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!= (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_NomeEmpregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}