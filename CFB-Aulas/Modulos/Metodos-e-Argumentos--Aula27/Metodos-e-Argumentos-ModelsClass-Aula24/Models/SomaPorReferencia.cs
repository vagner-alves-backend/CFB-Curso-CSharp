using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metodos_e_Argumentos_ModelsClass_Aula24.Models
{
    public class SomaPorReferencia 
    {
        public int PrimeiroNumber {get; set;}
        public int SegundoNumber {get; set;}
        public void Soma(ref int resposta)
        {
            resposta = PrimeiroNumber + SegundoNumber;
        }

        public void Multiplicacao(int number, out int resposta)
        {
            resposta = number * (PrimeiroNumber + SegundoNumber);
        }

        public int Calculo(params int[]number)
        {
            int resp = 0;
            if (number.Length < 2)
            {
                Console.WriteLine("Não a parameros o suficiente.");
            } else
            {
                foreach (int num in number)
                {
                    resp += num;
                }
                resp *= PrimeiroNumber;
            }
            return resp;
        }
    }
}