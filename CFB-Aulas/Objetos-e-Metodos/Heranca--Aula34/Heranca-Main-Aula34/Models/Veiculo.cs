using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Main_Aula34.Models
{
    public class Veiculo(bool iscarro, bool ligado, bool lavado, double gasolina)
    {
        private readonly bool _carro = iscarro;
        private readonly bool _ligado = ligado;
        private readonly bool _limpo = lavado;
        private readonly double _gasolina = gasolina;
        
        public Veiculo(): this(false, false, false, 2.5){}
        public Veiculo(double gasolina) : this(false, false, false, gasolina){} 
        public Veiculo(bool iscarro, bool lavado) : this(iscarro, lavado, false, 2.5){}

        public bool Ligar() => _ligado;
        public bool IsCarro() => _carro;
        public bool Lavado() => _limpo;
        public double Gasolina() => _gasolina;
    }
}
