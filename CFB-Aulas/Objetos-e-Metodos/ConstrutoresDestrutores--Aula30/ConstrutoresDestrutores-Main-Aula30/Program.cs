using System.Data.Common;
using ConstrutoresDestrutores_Main_Aula30.Models;

ConstructObject[] pessoa = [new(20), new("Bruno"), new("Laura", 19)];
for (int index = 0; index < pessoa.Length; index++)
{
    Console.WriteLine($"Name: {pessoa[index].GetName()} {pessoa[index].GetIdade(), 10}");
}
Console.WriteLine("------------------------");

// Trate number info...
string? numberText = "Null";
int number = 0;
Console.Write("Informe um number..: ");
numberText = Console.ReadLine();
number = TrateNumberInfo.NumberValid(numberText);
Console.WriteLine($"The number was processed... [{number}]");
Console.WriteLine("------------------------");

//Operador this.
OperadorThis[] isThis = [new("Vágner", 20), new("Lucas", 19), new("Matheus", 27)];
string? userName = "name";
int userIdade = 0;
for (int index = 0; index < isThis.Length; index++)
{
    userName = isThis[index].GetName();
    userIdade = isThis[index].GetIdade();
    Console.WriteLine($"...{userName} - {userIdade}");    
}
