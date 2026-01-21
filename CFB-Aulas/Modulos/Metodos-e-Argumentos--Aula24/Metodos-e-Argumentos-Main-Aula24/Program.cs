using Metodos_e_Argumentos_ModelsClass_Aula24.Models;
//Metodos e Argumentos aula 24 canal CFB Cursos -- Curso de C# 

// Referências, As referências tem um comportamento parecido com os ponteiros.
//Referência pelo método ref...
int resp = 14;
SomaPorReferencia calculo = new()
{
    PrimeiroNumber = 5,
    SegundoNumber = 6
};
Console.WriteLine("---Referência com ref: ");
Console.WriteLine($"\tAntes do método..[{resp}]");
calculo.Soma(ref resp);
Console.WriteLine($"\tDepois do método..[{resp}]");

//Referência pelo método out...
resp = 17;
Console.WriteLine("---Referência com out: ");
Console.WriteLine($"\tAntes do método..[{resp}]");
calculo.Multiplicacao(5, out resp);
Console.WriteLine($"\tDepois do método..[{resp}]");
