using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores_Main_Aula30.Models
{
    public class ConstructObject(string name, int idade)
    {
        //Construtores...
        public string? Name {get;} = name;
        public int Idade {get;} = idade;

        //Destrutores...
        ~ConstructObject() => Console.WriteLine("Parametros Destruidos.");
    }
}
