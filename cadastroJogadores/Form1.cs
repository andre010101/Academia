using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cadastroJogadores
{
    public partial class Form_Principal : Form
    {
        List<jogador> listaNomes = new List<jogador>();


        public Form_Principal()
        {
            InitializeComponent();
         
           


            try
            {
                StreamReader leitor = new StreamReader("C:\\Users\\andre\\OneDrive\\Área de Trabalho\\jogadores.csv", true);
                string linha;
                string[] vetorDados;
                do
                {
                 

                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(";");
                    listaNomes.Add(new jogador(vetorDados[0], vetorDados[1]));
                    textBox1_listasNomes.AppendText(vetorDados[0] + " - " + vetorDados[1] + Environment.NewLine);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"The file could not be opened: '{e}'");
            }

        }




        private void button_trocar_Click(object sender, EventArgs e)
        {
            titulo.BackColor = Color.BlueViolet;

        }


        private void button1_limapar_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("C:\\Users\\andre\\OneDrive\\Área de Trabalho\\jogadores.csv");
            if (fi.Exists)
                fi.CreateText();
       
            textBox1_listasNomes.Clear();
            listaNomes.Clear();
            label1_TotalNomes.Text = "Total: 0";
        }

        private void button1_Inserir_Click(object sender, EventArgs e)
        {
            if (textBox1_Namejogador.Text.Equals(""))

            {
                MessageBox.Show("É preciso digitar um nome  completo", "Alerta");
                return;
            }

            textBox1_Namejogador.Text = textBox1_Namejogador.Text.ToUpper();
            string email;

            if (jogador.jaCasdatrado(textBox1_Namejogador.Text, listaNomes))
            {
                MessageBox.Show("jogador já cadastrado!", "Alerta");
            }
            else
            {
                string[] vetorNomes = textBox1_Namejogador.Text.ToLower().Split(" ");

                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + '.' + vetorNomes[0] + "@ufn.edu.br";
                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }
                listaNomes.Add(new jogador(textBox1_Namejogador.Text, email));
                     
                textBox1_listasNomes.AppendText(textBox1_Namejogador.Text + " - " + email + Environment.NewLine);
                StreamWriter escritor = new StreamWriter("C:\\Users\\andre\\OneDrive\\Área de Trabalho\\jogadores.csv", true);
                escritor.WriteLine(textBox1_Namejogador.Text + ";" + email);
                escritor.Close();
                label1_TotalNomes.Text = "Total: " + listaNomes.Count();

            }
            
            textBox1_Namejogador.Text = "";
            textBox1_Namejogador.Focus();
        }

        private void button1_deletarArquivo_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\andre\\OneDrive\\Área de Trabalho\\jogadores.csv");
        }
    }
}