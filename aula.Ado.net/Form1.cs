using System.Data;

namespace aula.Ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Gravar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = textBox1_nome.Text;
            p.peso = float.Parse(textBox2_Peso.Text);   

            if(p.gravar())
            {
                MessageBox.Show("Pessoa inserida com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir a pessoa!");
            }
        }

        private void button2_Consultar_Click(object sender, EventArgs e)
        {
            Banco db = new Banco(); 
            DataTable dt = new DataTable();
            dt = db.executaConsulta("select * from pessoas");

           dataGridView1.DataSource = dt;


        }

        private void button3_Filtrar_Click(object sender, EventArgs e)
        {
            Banco db = new Banco();
            DataTable dt = new DataTable();
            dt = db.executaConsulta("select * from pessoas " +
                "where nome = '" + textBox1_Filtro.Text + "'");

            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco db = new Banco();
            DataTable dt = new DataTable();
            dt = db.executaConsulta("Delete * from pessoas " +
                "where nome = '" + textBox1_Filtro.Text + "'");

            dataGridView1.DataSource = dt;

        }

        
    }
}