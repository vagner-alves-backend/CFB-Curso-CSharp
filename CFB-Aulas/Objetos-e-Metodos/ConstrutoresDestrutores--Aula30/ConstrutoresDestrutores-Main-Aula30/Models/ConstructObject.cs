using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores_Main_Aula30.Models
{
    // public class ConstructObject(string name, int idade)
    // {
    //     //Construtores...
    //     public string? Name {get;} = name;
    //     public int Idade {get;} = idade;
    //     //Destrutores...
    //     ~ConstructObject() => Console.WriteLine("Parametros Destruidos.");
    // }

    public class ConstructObject    
    {
        private readonly string? _name;
        private readonly int _idade;

        //Sobre carga de construtores...
        public ConstructObject() : this("UserName", 18){}
        public ConstructObject(string? name) : this(name, 18) {}
        public ConstructObject(int idade) : this("UserName", idade){}
        public ConstructObject(string? name, int idade)
        {
            _name = name;
            _idade = idade;
        }

        public string? GetName() => _name;
        public int GetIdade() => _idade;
        ~ConstructObject() => Console.WriteLine("Parametros Destruidos");
    }
}
