using Atividade09___arquivos.Ex03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09___arquivos.Ex01
{
    internal class Ferramentas1
    {
        public static void gravarNomesArquivo(NomesCompletos Nomes, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true); //abre o arquivo para escrita
            escritor.WriteLine(Nomes.nomes);
            escritor.Flush();
            escritor.Close();
        }




        public static void popularArquivoNaListaNomesCompletos(List<NomesCompletos> lista, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                NomesCompletos nomesCompletos;
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    linha = leitor.ReadLine();
                    dadosLinha = linha.Split(";");
                    nomesCompletos = new NomesCompletos(dadosLinha[0]);
                    lista.Add(nomesCompletos);
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Deu problema no arquivo ou o arquivo está vazio!");
            }




          
        }

        public static bool jaNaListaNomesCompleto(NomesCompletos nomesCompletos, List<NomesCompletos> lista)
        {

            foreach (var i in lista)
            {
                if (nomesCompletos.nomes == i.nomes)
                {
                    return true; //nomes localizada pelo codigo
                }
            }
            return false; //nomes não localizada pelo codigo
        }
    }
}
