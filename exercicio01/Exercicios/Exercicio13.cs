﻿//13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
//preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
//vendidas pelo vendedor, calcule e mostre: o salário do empregado
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{ 

    internal class Exercicio13
    {
        public static void Ex13()
        {
            double numeroBicicletasVendidas,
            salarioBrutoFuncionario, salarioFuncionario, precoUnidadeBicicleta, acrescimo,
            valorBicicletaComAcrescimo, comissao, comicaoFuncionario;

            salarioFuncionario = 2424;

            numeroBicicletasVendidas = 15;
            comissao = 0.15;
            precoUnidadeBicicleta = 300;
            acrescimo = 0.50;



            valorBicicletaComAcrescimo = (precoUnidadeBicicleta * acrescimo) + precoUnidadeBicicleta;
            comicaoFuncionario = (comissao * precoUnidadeBicicleta);


            salarioBrutoFuncionario = (comicaoFuncionario * numeroBicicletasVendidas) + salarioFuncionario;



            Console.WriteLine($"O valor de cada bicicleta é de {valorBicicletaComAcrescimo}");
            Console.WriteLine($"O salario total do funcionario é de {salarioBrutoFuncionario}");
        }
    }
}