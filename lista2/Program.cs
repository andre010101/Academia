namespace lista2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Pessoa> pessoas;

            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Ricardo", 40));
            pessoas.Add(new Pessoa("Jefferson",25 ));
            pessoas.Add(new Pessoa("Mirian",45 ));

            foreach(Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + "" +p.Idade);
            }
            Console.ReadLine();

            Console.WriteLine("lista não ordenada");
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });


            Console.WriteLine("lista ordenada por nome ");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });



            Console.WriteLine("lista ordenada por idade ");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Idade.CompareTo(p2.Nome);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });


            Console.WriteLine("inserir uma pessoa na posição 1 e outra na posição 3");
            pessoas.Insert(1, new Pessoa() { Nome = "bob dylan ", Idade = 78 });
            pessoas.Insert(3, new Pessoa() { Nome = "bob dylan ", Idade = 78 });


        }

        static void ListaLocalizaPessoasJovem()
        {
            List<Pessoa> jovem = pessoas.FindAll(delegate(Pessoa p ))  { retur p idade < 45; });
            Console.WriteLine("idade é menor que 25:");
            jovem.ForEach(delegate(Pessoa p))
                Console.WriteLine(p.nome+"" +   prop.idade     );
        }
        
    }
}