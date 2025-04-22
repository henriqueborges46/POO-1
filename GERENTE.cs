using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
    class GERENTE
    { using System;
using System.Globalization;

namespace RHApp
    {
        public class Gerente : Funcionario
        {
            public string Departamento { get; set; }

            public override void ExibirDados()
            {
                base.ExibirDados(); // Chama ExibirDados da classe base (Funcionario)
                Console.WriteLine($"DEPARTAMENTO: {Departamento}");

                if (Salario > 10000)
                {
                    Console.WriteLine("STATUS: Alta Gestão.");
                }
            }
        }
    }
}
}
