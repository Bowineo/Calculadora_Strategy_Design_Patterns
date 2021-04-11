using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Strategy___Design_Patterns_
{
    public class Somar : Calculadora
    {
        public double operacao(double v1, double v2)
        {
            return v1 + v2;
        }
    }
}
