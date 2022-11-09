using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroJogadores
{
    internal class jogador
    {
        string nome;
        string email;

        public jogador(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }


        public static bool jaCasdatrado(string nome, List<jogador> listaNomes)
        {
            

            foreach (jogador i in listaNomes)
            {
                if(nome.Equals(i.nome))
                {
                    return true;
                }
            }
            return false;
        }

      

    }
}
