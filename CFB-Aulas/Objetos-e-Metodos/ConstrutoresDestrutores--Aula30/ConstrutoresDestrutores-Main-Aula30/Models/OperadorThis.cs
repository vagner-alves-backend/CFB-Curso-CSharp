using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores_Main_Aula30.Models
{
    public class OperadorThis
    {
        private readonly string? _name;
        private readonly int _idade;
       
       public OperadorThis() : this("UserName", 0) {}
       public OperadorThis(string? name) : this(name, 18) {}
       public OperadorThis(string? name, int idade)
        {
            _name = name;
            _idade = idade;
        }

        public string? GetName() => _name;
        public int GetIdade() => _idade;
        ~OperadorThis() => Console.WriteLine("Object destruido.");
    }
}