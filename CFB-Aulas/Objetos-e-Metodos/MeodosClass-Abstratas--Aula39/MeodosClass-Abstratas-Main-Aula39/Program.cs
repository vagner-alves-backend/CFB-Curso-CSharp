using MeodosClass_Abstratas_Main_Aula39.Models;

Carro carro = new();
carro.Aceleracao(1);
Console.WriteLine($"Sua velocidade atual é: {carro.Velocidade(), 10}Km");

carro.Aceleracao(-1);
Console.WriteLine($"Sua velocidade atual é: {carro.Velocidade(), 10}Km");

carro.Aceleracao(10);
Console.WriteLine($"Sua velocidade atual é: {carro.Velocidade(), 10}Km");

carro.Aceleracao(-10);
Console.WriteLine($"Sua velocidade atual é: {carro.Velocidade(), 10}Km");

