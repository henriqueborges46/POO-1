using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
    class CALCULO
    {namespace CalculadoraApp
    {
        public class Calculo
        {
            public double ValorA { get; set; }
            public double ValorB { get; set; }
            public double Resultado { get; private set; }

            public void CalcularSoma()
            {
                Resultado = ValorA + ValorB;
            }

            public void CalcularSubtracao()
            {
                Resultado = ValorA - ValorB;
            }

            public void CalcularMultiplicacao()
            {
                Resultado = ValorA * ValorB;
            }

            public double RetornarMaior()
            {
                return (ValorA > ValorB) ? ValorA : ValorB;
            }

            public double SomarGeral(double valorExtra)
            {
                return ValorA + ValorB + valorExtra;
            }
        }
    }
}
}
