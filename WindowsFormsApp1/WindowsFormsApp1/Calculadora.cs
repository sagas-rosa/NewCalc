using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operacion { get; set; }

        public double Calcular()
        {
            switch (Operacion)
            {
                case "+": return Valor1 + Valor2;
                case "-": return Valor1 - Valor2;
                case "*": return Valor1 * Valor2;
                case "/":
                    if (Valor2 == 0)
                        throw new DivideByZeroException("No se puede dividir entre cero.");
                    return Valor1 / Valor2;
                default: throw new InvalidOperationException("Operación no válida.");
            }
        }
    }
  }
