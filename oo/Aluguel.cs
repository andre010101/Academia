using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    internal class Aluguel
    {

        public int dias=0;
        private int valor ;
        public Carro Carro;
        public Cliente cliente;

        public Aluguel(int dias, int valor, Carro carro, Cliente cliente)
        {
            this.dias = dias;
            this.valor = valor;
            Carro = carro;
            this.cliente = cliente;
        }


        public int getValorTotal()
        {
            
            

            return valor = dias * 100;
            Console.WriteLine("valor a ser cobrado" + valor);
        }
        public void setValorTotal(int total)
        {
            Console.WriteLine("Fahrdsadsaenhrit:" + total);
            valor = dias * 100; //coverte para celsisus
            Console.WriteLine("adas" + valor);
        }



    }
}
