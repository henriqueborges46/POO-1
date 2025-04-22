using System;

namespace RHApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cadastro de Funcionário ===");
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome completo: ");
            funcionario.NomeCompleto = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\n=== Cadastro de Gerente ===");
            Gerente gerente = new Gerente();
            Console.Write("Nome completo: ");
            gerente.NomeCompleto = Console.ReadLine();
            Console.Write("Salário: ");
            gerente.Salario = double.Parse(Console.ReadLine());
            Console.Write("Departamento: ");
            gerente.Departamento = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("=== DADOS FUNCIONÁRIO ===");
            funcionario.ExibirDados();

            Console.WriteLine("\n=== DADOS GERENTE ===");
            gerente.ExibirDados();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
