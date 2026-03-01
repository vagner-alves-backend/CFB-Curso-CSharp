using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct.Models
{
    public class Pessoa (string? name, string? sobrenome, int idade)
    {
        public string? Name = name;
        public string? Sobrenome = sobrenome;
        public int Idade = idade;
    }
}