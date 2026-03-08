if (args.Length != 0)
{
    Console.WriteLine("Foram passados argumentos...");
    foreach (string arg in args)
    {
        Console.WriteLine($"Argumento:\t{arg}");
    }
} else
{
    Console.WriteLine("Não foram passados argumentos.");
}
