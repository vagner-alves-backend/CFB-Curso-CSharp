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
Console.WriteLine($"\tAntes do método  {resp, 10}");
calculo.Soma(ref resp);
Console.WriteLine($"\tDepois do método {resp, 10}");

//Referência pelo método out...
resp = 17;
Console.WriteLine("---Referência com out: ");
Console.WriteLine($"\tAntes do método  {resp, 10}");
calculo.Multiplicacao(5, out resp);
Console.WriteLine($"\tDepois do método {resp, 10}");

//Parametro params...
resp = 4;
Console.WriteLine("---Por params: ");
Console.WriteLine($"\tAntes do método  {resp, 10}");
Console.WriteLine($"\tDepois do método {calculo.Calculo(5, 6, 7, 8, 9, 10), 10}\n");
