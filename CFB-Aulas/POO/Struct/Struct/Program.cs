using Struct.Models;

Console.Clear();
 
Pessoa[] pessoas = [
    new ("Vágner", "Alves", 20),
    new ("Matheus", "Souza", 24),
    new ("Sabrine", "Gomes", 19),
    new ("Larissa", "Sofia", 21)
];

Console.WriteLine("--Pessoas registradas...");
foreach (Pessoa pessoa in pessoas)
{
    Console.WriteLine(
        $"\tNome:      {pessoa.Name}\n"+
        $"\tSobrenome: {pessoa.Sobrenome}\n"+
        $"\tIdade:     {pessoa.Idade}\n"+
        "\t................................"
    );
}
Console.WriteLine("---------------------------------------------");
