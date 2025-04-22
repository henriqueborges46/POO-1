using System;

namespace EstacionamentoShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            VagaEstacionamento vaga1 = new VagaEstacionamento(101, "Carro");

            Console.WriteLine("Informações iniciais da vaga:");
            vaga1.ExibirInformacoes();

            Console.WriteLine("\n== Ocupando vaga ==");
            vaga1.OcuparVaga();
            vaga1.ExibirInformacoes();

            Console.WriteLine("\n== Tentando alterar tipo com vaga ocupada ==");
            vaga1.AlterarTipoVeiculo("Moto");

            Console.WriteLine("\n== Liberando vaga e alterando tipo ==");
            vaga1.LiberarVaga();
            vaga1.AlterarTipoVeiculo("Moto");
            vaga1.ExibirInformacoes();

            Console.WriteLine("\n== Tentando tipo inválido ==");
            vaga1.AlterarTipoVeiculo("Bicicleta");
        }
    }
}
