using ConstrutoresDestrutores_Main_Aula30.Models;

ConstructObject[] pessoa = [new("Vágner", 20), new("Bruno", 21), new("Laura", 19)];
for (int index = 0; index < pessoa.Length; index++)
{
    Console.WriteLine($"Name: {pessoa[index].Name} {pessoa[index].Idade, 10}");
}
