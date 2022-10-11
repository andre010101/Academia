using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.questao05
{
    internal class Produtos 
    {
        public string formaPg { get; set; }
        public string cartao { get; set; }
        public string dinheiro { get; set; }

        public string cheque { get; set; }

        public string nomeProduto { get; set; }
        public int quantidadeProduto { get; set; }

        public int valorProduto { get; set; }

        public int total { get; set; }

        public void SomarProdutos()
        {
            total = quantidadeProduto * valorProduto;
        }


        public void ApresentarProdutos()
        {
            Console.WriteLine($"-O produto:{nomeProduto} \n  -quantidade: {quantidadeProduto}\n -custa: {quantidadeProduto}\n");
            Console.WriteLine($"O valor de total de sua compra é de {total} Reais");
        }

        public void FormaDePagamento()
        {
            if(formaPg == "1")
            {
                double juros5;
                juros5 = total + 0.5;
                Console.WriteLine($"O pagamento no cartao fica {juros5} reais ");
            }
            if (formaPg == "2")
            {
                double juros10;
                juros10 = total + 0.9;
             
                Console.WriteLine($"O pagamento no cheque fica {juros10} reais ");
            }
            if (formaPg == "3")
            {
                double desconto10;
                desconto10 = total - 0.10;
                Console.WriteLine($"O pagamento no dinheiro fica {desconto10} reais ");
            }

        }

       
    }
}
