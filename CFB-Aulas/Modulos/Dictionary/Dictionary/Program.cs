Dictionary <int, string?> pessoa = [];

pessoa.Add (123, "Vágner");
pessoa.Add (234, "Lucas");
pessoa.Add (345, "Matheus");
pessoa.Add (456, "Larissa");
pessoa.Add (567, "Sofia Souza");
pessoa.Add (678, "Sabrine");

// Verifique o número de registros no Dictionary
Console.WriteLine ($"Existem {pessoa.Count} registros...");

// Pesquise por um registro especifico
if (pessoa.ContainsKey (234))
{
    Console.WriteLine ("O registro referente a key: 234, foi encontrado...");
} 

// Para remover um registro usamos o comando
pessoa.Remove (567);
Console.WriteLine ("O elemento referente a key: 567, foi removido...");

// pesquisando pelo valor 
if (pessoa.ContainsValue ("Lucas"))
{
    Console.WriteLine ("O elemento referente ao valor 'Lucas', foi encontrado...");
}

// Mudando o valor referente a chave
pessoa[345] = "Laura";
Console.WriteLine ("O valor da chave: 345, foi alterado...");

//Imprimindo todos os registros do dictionary
Console.WriteLine ("----------------------------------");
foreach (KeyValuePair <int, string?> registro in pessoa)
{
    Console.WriteLine ($"Name: {registro.Value} - Password: {registro.Key}");
}
Console.WriteLine ("----------------------------------");
