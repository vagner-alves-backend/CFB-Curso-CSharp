using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_Main_Aula34.Models
{
    public class Carro:Veiculo
    {
        private readonly string? _chassi;
        private readonly string? _placa;
        private readonly bool _step;
        private readonly bool _vidroAberto;
        private readonly bool _portaAberta;
        public Carro(string? chassi, string? placa) : this(chassi, placa, false, false, false){}
        public Carro(string? chassi, string? placa, bool step) : this(chassi, placa, step, false, false){}
        public Carro(string? chassi, string? placa, bool step, bool vidroAberto) : this(chassi, placa, step, vidroAberto, false){}
        public Carro(string? chassi, string? placa, bool step, bool vidroAberto, bool portaAberta) 
        {
            this._chassi = chassi;
            this._placa = placa;
            this._step = step;
            this._vidroAberto = vidroAberto;
            this._portaAberta = portaAberta;
        }
        
        
    }
}