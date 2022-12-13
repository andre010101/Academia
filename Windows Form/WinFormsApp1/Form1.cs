namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1_Nome.Text.Length == 0 )
            {
                MessageBox.Show("É necessário informar o campo Nome", "Atenção");
            }
            else
            {
                Pessoa pessoa = new Pessoa(textBox1_Nome.Text);
                listaPessoas.Add(pessoa);
                atualizarTextBox_listaPessoas();

            }
        }

        private void limparCampos()
        {
            textBox1_Nome.Clear();
        }

   
     private void atualizarTextBox_listaPessoas()
        {
            

            foreach (var i in listaPessoas)
            {
                textBox1_Nome.Text += i.Nome + Environment.NewLine;
            }
        }
    }
}