
using System.Configuration;
using System.Data.SqlClient;

namespace CadastroGlicemia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

      

        private void ConectarButton_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
            SqlCommand comando = new SqlCommand(sqlTexto, conexao);

            listView1.Items.Clear();
            SqlDataReader leitor = comando.ExecuteReader();
            int i = 0;
            while (leitor.Read())
            {
                listView1.Items.Add(leitor["idMedidaGlicemia"].ToString());
                listView1.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                listView1.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                listView1.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                i++;
            }

            conexao.Close();
        }

        private void button1_cadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(textBox1_idMedidaGlicemia.Text);
                int valorGlicemia = int.Parse(textBox2_valorGlicemia.Text);
                string dataMedida = textBox3_dataMedida.Text;
                int idPaciente = int.Parse(textBox4_idPaciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }

        private void Button_Remover_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(listView1.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
        }
    }
}