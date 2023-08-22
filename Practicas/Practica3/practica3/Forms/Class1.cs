using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1.Forms
{
    internal class Calculadora
    {

        double num1, num2, resultado;

        public Calculadora(double _num1, double _num2)
        {
            this.num1 = _num1;
            this.num2 = _num2;
        }

        public double Suma() => resultado = num1 + num2;

        public double Resta() => resultado = num1 - num2;

        public double Mulriplicacion() => resultado = num1 * num2;

        public double Division() => resultado = num1 / num2;

    }
}
