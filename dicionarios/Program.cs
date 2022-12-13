using System.Security;

namespace dicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDictionary <int,string>dic1 =new Dictionary<int,string>();
            //dic1.Add(1, "Maria");
            //dic1.Add(2, "Paulo");
            //dic1.Add(3, "Pedro");

            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                                                      { 1,"banana"},
                                                      { 2,"Laranja"},
                                                      { 3,"Manga"},
                                                      { 4,"Abacate"},
                                                      { 5,"Maça"}



            };
            string resultado;
            if(dic1.TryGetValue(1,out resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("não foi posivel achar a chave especifica");
            }

            //verificar se o item consta no dicionario 
            Console.WriteLine(dic1.ContainsKey(1));//retorna true
            Console.WriteLine(dic1.ContainsKey(6));//retorna false

            Console.WriteLine(dic1.ContainsValue("Manga"));//retorna true
            //Console.WriteLine(dic1[2]);
            //foreach (keyValuePair<int, string> item in dic1)
            //{
            //    Console.WriteLine(item.key+""+item.value);
            //}
            dic1.Remove(3);//remover o item 2
            //apresentar todos os items
            foreach (KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine("item:" + item.Key+ "" +item.Value);
            }

            string fruta;
            dic1.Remove(3, out fruta );
            Console.WriteLine(fruta);//item removido

            //criando um dicionario ordenado 
            SortedDictionary<string, int> dic2 = new SortedDictionary<string, int>();
            //adicionar strings e chaves do tipo int
            dic2.Add("zebra", 5);
            dic2.Add("cachorro", 2);
            dic2.Add("gato", 9);
            dic2.Add("pardal", 4);
            dic2.Add("c#", 100);
            //verifica  se o gato existe no dicionario
            if (dic2.ContainsKey("gato")) 
            {
                Console.WriteLine("tem um gato ai..");
            }
            if (dic2.ContainsKey("zebra"))
            {
                Console.WriteLine("tem um zebra ai..");
            }
            //VerificationException se contem c#
            //se tiver pega o valor

            int v;
            if (dic2.TryGetValue("C#", out v))
            {
                Console.WriteLine(v);
            }
            //imprime o sorte

            foreach (KeyValuePair<string, int> p in dic2)
            {
                Console.WriteLine(p.Key+ ""+ p.Value);
            }
            Console.ReadLine();
        }
    }
}