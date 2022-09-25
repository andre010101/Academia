//12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
//marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido
//dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

//Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia 

//Média do consumo = Total quilometragem/ quantidade de combustível gasto

//Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

namespace exercicio01.Exercicios
{

    internal class Exercicio12
    {
        public static void Ex12()
        {
            double combustivelInicialLitro, quilometragem, mediaConsumo, lucroLiquidoDia, marcadorInicialKm, totalQuilometragem, marcadorFinalKm, combustivelPrecoLitro, conbustivelTotalPrecoLitro, valorDaCorida, CorridasFeitas, lucroDoDia, valorPagoEmCorridas;
            valorDaCorida = 10.00;
            CorridasFeitas = 100;
            combustivelPrecoLitro = 6.90;
            combustivelInicialLitro = 50;
            quilometragem = 1000;
            marcadorInicialKm = 20;
            marcadorFinalKm = 800;



            valorPagoEmCorridas = valorDaCorida * CorridasFeitas;
            conbustivelTotalPrecoLitro = combustivelPrecoLitro * combustivelInicialLitro;
            totalQuilometragem = marcadorFinalKm - marcadorInicialKm;
            lucroDoDia = valorPagoEmCorridas - conbustivelTotalPrecoLitro;


            Console.WriteLine($"Valor ganho em corridas {valorPagoEmCorridas} Reais");
            Console.WriteLine($"total quilometragem {totalQuilometragem}km");
            Console.WriteLine($"Valor total gasto em combustivel  {conbustivelTotalPrecoLitro} Reais");
            Console.WriteLine($"O lucro do Motorista sera de {lucroDoDia} Reais");
        }
    }

}