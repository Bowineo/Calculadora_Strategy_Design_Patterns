﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Strategy___Design_Patterns_
{
    public class Subtrair : Calculadora
    {
        public double operacao(double v1, double v2)
        {
            if (v2 > v1) throw new InvalidOperationException();
            return v1 - v2;
        }
    }
}
