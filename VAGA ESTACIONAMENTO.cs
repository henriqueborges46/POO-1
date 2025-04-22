using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_4
{
    class VAGA_ESTACIONAMENTO
    { using System;

namespace EstacionamentoShopping
    {
        public class VagaEstacionamento
        {
            // Atributos privados
            private readonly int numeroVaga;
            private bool ocupada;
            private string tipoVeiculo;

            // Property para numeroVaga (somente leitura)
            public int NumeroVaga => numeroVaga;

            // Property para ocupada (leitura e escrita interna)
            public bool Ocupada
            {
                get { return ocupada; }
                private set { ocupada = value; }
            }

            // Property para tipoVeiculo com validação
            public string TipoVeiculo
            {
                get { return tipoVeiculo; }
                private set
                {
                    if (value == "Carro" || value == "Moto" || value == "Caminhão")
                    {
                        tipoVeiculo = value;
                    }
                    else
                    {
                        throw new ArgumentException("Tipo de veículo inválido. Use apenas 'Carro', 'Moto' ou 'Caminhão'.");
                    }
                }
            }

            // Construtor
            public VagaEstacionamento(int numeroVaga, string tipoVeiculo)
            {
                this.numeroVaga = numeroVaga;
                this.TipoVeiculo = tipoVeiculo; // validação automática
                this.Ocupada = false; // inicia desocupada
            }

            // Métodos públicos
            public void OcuparVaga()
            {
                Ocupada = true;
            }

            public void LiberarVaga()
            {
                Ocupada = false;
            }

            public void AlterarTipoVeiculo(string novoTipo)
            {
                if (!Ocupada)
                {
                    try
                    {
                        TipoVeiculo = novoTipo;
                        Console.WriteLine("Tipo de veículo alterado com sucesso.");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Não é possível alterar o tipo de veículo com a vaga ocupada.");
                }
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Vaga Nº: {NumeroVaga}");
                Console.WriteLine($"Tipo de Veículo: {TipoVeiculo}");
                Console.WriteLine($"Status: {(Ocupada ? "Ocupada" : "Livre")}");
            }
        }
    }
}
}
