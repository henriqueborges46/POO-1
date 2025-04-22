using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
    class FUNCIONARIO
    { using System;
using System.Globalization;

namespace RHApp
    {
        public class Funcionario
        {
            public string NomeCompleto { get; set; }
            public double Salario { get; set; }

            public virtual void ExibirDados()
            {
                string[] nomes = NomeCompleto.Split(' ');
                string ultimoSobrenome = nomes[nomes.Length - 1].ToUpper();

                Console.WriteLine($"SOBRENOME: {ultimoSobrenome}");
                Console.WriteLine($"SALÁRIO: {Salario.ToString("C", new CultureInfo("pt-BR"))}");
            }
        }
    }
}
}
