using System.Reflection.Metadata;

namespace manupulandoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "C:\\Users\\andre\\OneDrive\\Área de Trabalho\\exemplo1.txt";

            File.Create(filePath);
        }
    }
}