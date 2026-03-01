using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeodosClass_Abstratas_Main_Aula39.Models
{
    public abstract class Veiculo
    {
        protected int velocidadeMaxima;
        protected int VelocidadeAtual;
        public Veiculo()
        {
            this.velocidadeMaxima = 150;
        }
        public abstract void Aceleracao(int aceleracao);
    }
}