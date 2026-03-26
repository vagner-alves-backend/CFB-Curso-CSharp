List <string?> names = [];

//Para adicionarmos elementos a uma lista usamos o comando : 
names.Add ("Vágner Alves");
names.Add ("Gustavo Henrique");
names.Add ("Sofia Valverde");
names.Add ("Sabrine Mendes");

// Para copiarmos os elementos de uma lista em outra, usamos o comando : 
List <string?> novaLista = [];
novaLista.Capacity = names.Count;

novaLista.AddRange (names);

// Para buscar por um elemento podemos usar o comando : 
if (names.Contains ("Vágner Alves"))
{
    Console.WriteLine ("\tO nome foi encontrado.");
} else
{
    Console.WriteLine ("\tO elemento não foi encontrado.");
}

// Para buscar um elemento pelo index usamos o comando : 
int position = names.IndexOf ("Sabrine Mendes");
Console.WriteLine ($"\tO nome está na posição: {position}");

// Para removermos elementos usamos os comandos : 
names.Remove ("Gustavo Henrique");
names.RemoveAt (1);


Console.WriteLine ("Lista de nomes...");
foreach (string? name in names)
{
    Console.WriteLine ($"\t- {name}");
}
Console.WriteLine ("---------------------------");
