using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Main_Aula34.Models
{
    public class Veiculo
    {
        public string? IsCarro;
        private readonly bool _ligado;
        public bool Lavado {get; set;}
        public double Gasolina {get; set;}
        
        public Veiculo(): this("Carro", false, false, 2.5){}
        public Veiculo(string iscarro, bool lavado) : this(iscarro, lavado, false, 2.5){}
        public Veiculo(string iscarro, bool ligado, bool lavado, double gasolina)
        {
            this.IsCarro = iscarro;
            this._ligado = ligado;
            this.Lavado = lavado;
            this.Gasolina = gasolina;
        }

        public string? LigarCarro() => _ligado ? "Ligado" : "Desligado";
        public string? CarroMoto() => IsCarro;
    }
}
