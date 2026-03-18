Console.Clear ();

LinkedList <string?> names = [];

// Adicionando nome no inicio da lista...
names.AddFirst ("Vágner Alves");
names.AddFirst ("Laura Gomes");
names.AddFirst ("Debora Souza");

// Adicionando nome no final da lista...
names.AddLast ("Sofia Valverde");

// Criando o no de referencia...
LinkedListNode <string?>? no;

// Adicionando um nome depois do nome "Vágner Alves"...
no = names.FindLast ("Vágner Alves")?.Next; // Next faz com que ele aponte para o proximo elemento...
if (no != null)
{
    names.AddAfter (no, "Luana Souza");
}

// Adicionando um nome antes do nome "Sofia Valverde"...
no = names.FindLast ("Sofia Valverde")?.Previous; // Previous faz com que ele aponte para o elemento anterior...
if (no != null)
{
    names.AddBefore (no, "Luciene Gomes");
}

Console.WriteLine ("---Lista de nomes...");
foreach (string? name in names)
{
    Console.WriteLine ($"\t{name}");
}
Console.WriteLine ("--------------------------");
