using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Heranca_Main_Aula34.Models
{
    public class Carro : Veiculo
    {
        private readonly string? _chassi;
        private readonly string? _placa;
        private readonly bool _step;
        private readonly bool _vidroAberto;
        private readonly bool _portaAberta;
        
        public Carro(string? chassi, string? placa, bool step, bool vidro, bool porta, double gasolina) : base (gasolina)
        {
            this._chassi = chassi;
            this._placa = placa;
            this._step = step;
            this._vidroAberto = vidro;
            this._portaAberta = porta;
        }

        public Carro(string? chassi, string? placa) : this(chassi, placa, false, false, false, 2.5){}
        public Carro(bool step, bool vidro, bool porta, double gasolina) : this ("chassi", "placa", step, vidro, porta, gasolina){}

        public void CarroPropriedades()
        {
            //Propriedades locais.
            Console.WriteLine(
                $"Chassi.......: {_chassi, 15}\n"+
                $"Placa........: {_placa, 15}\n"+
                $"Step.........: {_step, 15}\n"+
                $"Vidro aberto.: {_vidroAberto, 15}\n"+
                $"Porta aberta.: {_portaAberta, 15}\n"
            );
            //Propriedades herdadas.
            Console.WriteLine(
                $"Ligado.......: {Ligar(), 15}\n"+
                $"Foi lavado...: {Lavado(), 15}\n"+
                $"Gasolina.....: {Gasolina(), 15}L\n"
            );
            Console.WriteLine("-------------------------------");
        }
        
    }
}
