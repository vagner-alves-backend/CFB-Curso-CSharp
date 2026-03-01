using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MeodosClass_Abstratas_Main_Aula39.Models
{
    public class Carro : Veiculo
    {
        public override void Aceleracao(int aceleracao)
        {
            this.VelocidadeAtual += aceleracao*10;
        }
        public int Velocidade()
        {
            if (this.VelocidadeAtual < 0)
            {
                this.VelocidadeAtual = 0;
            } else if (this.VelocidadeAtual > 150)
            {
                this.VelocidadeAtual = 150;
            } 

            return this.VelocidadeAtual;
        }
    }
}

