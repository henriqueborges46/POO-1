using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    class CALCULADORA
    {using System;

namespace CalculadoraApp
    {
        public class Calculadora
        {
            private Calculo calculo;

            public Calculadora()
            {
                calculo = new Calculo();
            }

            public void ExecutarCalculadora()
            {
                bool continuar = true;
                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("=== CALCULADORA ===");
                    Console.WriteLine("1. Ler valores");
                    Console.WriteLine("2. Somar");
                    Console.WriteLine("3. Subtrair");
                    Console.WriteLine("4. Multiplicar");
                    Console.WriteLine("5. Retornar maior valor");
                    Console.WriteLine("6. Somar geral (A + B + valor externo)");
                    Console.WriteLine("7. Sair");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            LerValores();
                            break;
                        case "2":
                            calculo.CalcularSoma();
                            ImprimirResultado();
                            break;
                        case "3":
                            calculo.CalcularSubtracao();
                            ImprimirResultado();
                            break;
                        case "4":
                            calculo.CalcularMultiplicacao();
                            ImprimirResultado();
                            break;
                        case "5":
                            double maior = calculo.RetornarMaior();
                            Console.WriteLine($"Maior valor: {maior}");
                            break;
                        case "6":
                            Console.Write("Informe o valor adicional: ");
                            double valorExtra = double.Parse(Console.ReadLine());
                            double resultado = calculo.SomarGeral(valorExtra);
                            Console.WriteLine($"Resultado soma geral: {resultado}");
                            break;
                        case "7":
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    if (opcao != "7")
                    {
                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                }
            }

            public void LerValores()
            {
                Console.Write("Digite o valor A: ");
                calculo.ValorA = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor B: ");
                calculo.ValorB = double.Parse(Console.ReadLine());
            }

            private void ImprimirResultado()
            {
                Console.WriteLine($"Resultado: {calculo.Resultado}");
            }
        }
    }
}
}
