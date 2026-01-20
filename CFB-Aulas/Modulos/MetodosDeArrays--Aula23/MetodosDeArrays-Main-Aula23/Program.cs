using MetodosDeArrays_ModelsClass_Aula23.Models;
MenuDeMetodos metodos = new();

bool newTest = true;

Random numberRandom = new();
int[] vetorRandom = new int[17];
for (int index = 0; index < vetorRandom.Length; index++)
{
    vetorRandom[index] = numberRandom.Next(0, 10);
}

vetorRandom.CopyTo(metodos.VetorInfo, 0);
int returnErro = 0;
int optionMenu = 0;
int number = 0;

string? optionMenuText = "Null";

Console.Clear();
do
{
    do
    {
        Console.Write(
            "opçoes---\n"+
            "\t1. BinarySearch\n"+
            "\t2. Copy\n"+
            "\t3. IndexOf\n"+
            "\t4. LastIndexOf\n"+
            "\t5. Sort-Reverse\n"+
            "\t6. End..: "
        );        
        optionMenuText = Console.ReadLine();
        newTest = int.TryParse(optionMenuText, out returnErro);
        if (newTest == false)
        {
            Console.WriteLine("-[Erro]: Valor invalido..");
        } else
        {
            optionMenu = Convert.ToInt32(optionMenuText);
            if (optionMenu < 1 || optionMenu > 6)
            {
                Console.WriteLine("[Erro]: Opção não encontrada.");
                newTest = false;
            }
        }

    } while (!newTest);
    Console.Clear();
    if (optionMenu != 6 && optionMenu != 5 && optionMenu != 2)
    {
        number = metodos.InfoNumber();
    }

    switch (optionMenu)
    {
        case 1:
            vetorRandom.CopyTo(metodos.VetorAlternative, 0);
            Array.Sort(metodos.VetorAlternative);
            if (metodos.VetorAlternative.BinarySearch(number) > 0)
            {
                Console.WriteLine($"O valor informado está no index [{metodos.VetorAlternative.BinarySearch(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 2:
            vetorRandom.CopyTo(metodos.VetorAlternative, 0);
            for (int index = 0; index < metodos.VetorAlternative.Length; index++)
            {
                Console.Write($"[{metodos.VetorAlternative[index]}] ");
            }
            Console.WriteLine();
            break;
        case 3:
            if (vetorRandom.IndexOf(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{vetorRandom.IndexOf(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 4:
            if (vetorRandom.LastIndexOf(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{vetorRandom.LastIndexOf(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 5:
            Console.WriteLine("Vetor ordenado..");
            Console.Write("Ordem Crescente..:\t");
            Array.Sort(vetorRandom);
            foreach (int ordemCrescente in vetorRandom)
            {
                Console.Write($"{ordemCrescente} ");
            }
            Console.Write("\nOrdem Decrescente..:\t"); 
            Array.Reverse(vetorRandom);
            foreach (int ordemDecrescente in vetorRandom)
            {
                Console.Write($"{ordemDecrescente} ");
            }
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Fim do progama.");
            newTest = false;
            break;

        default:
            Console.WriteLine("[Erro]: Opção não encotrada");
            newTest = false;
            break;
    }
} while (newTest);
