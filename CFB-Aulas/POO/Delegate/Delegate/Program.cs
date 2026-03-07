using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Delegate.Models;

Console.Clear();

Operacao adicao = Calculadora.Adicao;
Operacao subtracao = Calculadora.Subtracao;
Operacao multiplicacao = Calculadora.Multiplicacao;
Operacao divisao = Calculadora.Divisao;

bool _continue = true;
string? calculoSimbolo  = "";
string? valor1 = "";
string? valor2 = "";
int number1 = 0;
int number2 = 0;
int resultado = 0;

do
{
    Console.Write(
        "---Calculadora....\n"+
        "Deseja:\n"+
        "\t...[+]...\n"+
        "\t[x]...[:]\n"+
        "\t...[-]...\n"+
        "-> "
    );   
    calculoSimbolo = Console.ReadLine();
    Console.Clear();

    Console.Write(
        "Informe os valores...\n"+
        "Primeiro valor: "
    );
    valor1 = Console.ReadLine();

    Console.Write("Segundo valor: ");
    valor2 = Console.ReadLine();
    Console.WriteLine("--------------------------------");

    if (int.TryParse(valor1, out number1) && int.TryParse(valor2, out number2))
    {
        if (calculoSimbolo == "+" || calculoSimbolo == "-" || calculoSimbolo == ":" || calculoSimbolo == "x") 
        {
            resultado = calculoSimbolo switch
            {
                "+" => adicao (number1, number2),
                "-" => subtracao (number1, number2),
                ":" => divisao (number1, number2),
                "x" => multiplicacao (number1, number2),
                _ => 0
            };

            Console.WriteLine ($"\t{number1} {calculoSimbolo} {number2} = {resultado}");
        } else
        {
            Console.WriteLine ("Simbolo de calculo não encontrado");
        }
    }

    Console.WriteLine("--------------------------------");
    Console.Write ("Deseja continuar? [s/n]: ");
    _continue = Console.ReadLine() == "s";
    Console.WriteLine("--------------------------------");
} while (_continue);
