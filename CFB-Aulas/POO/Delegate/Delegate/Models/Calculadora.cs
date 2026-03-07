using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegate.Models
{
    // Escopo global....
    public delegate int Operacao (int number1, int number2);
    public class Calculadora
    {
        public static int Adicao (int number1, int number2) => number1 + number2;
        public static int Subtracao (int number1, int number2) => number1 - number2;
        public static int Multiplicacao (int number1, int number2) => number1 * number2;
        public static int Divisao (int number1, int number2) => number1 / number2;
    }
}
