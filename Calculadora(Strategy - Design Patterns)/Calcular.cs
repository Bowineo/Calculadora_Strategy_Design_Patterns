using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Strategy___Design_Patterns_
{
    public class Calcular
    {
        public Calculadora calcular { get; set; }

        public void CalcularOperacao(double n1, double n2)
        {
            Console.WriteLine(calcular.operacao(n1, n2));
        }
    }
}
