using MetodosDeArrays_ModelsClass_Aula23.Models;

MenuDeMetodos metodos = new();


bool newTest = true;

int returnErro = 0;
int optionMenu = 0;
int number = 0;

int[] vetorNumber = [1, 2, 3, 4, 5, 6, 7, 8, 9, 5, 4, 2, 1, 8, 9, 6, 5];
int[] vetorAlternative = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];


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
            "\t5. End..: "
        );        
        optionMenuText = Console.ReadLine();
        newTest = int.TryParse(optionMenuText, out returnErro);
        if (newTest == false)
        {
            Console.WriteLine("-[Erro]: Valor invalido..");
        } else
        {
            optionMenu = Convert.ToInt32(optionMenuText);
            if (optionMenu < 1 || optionMenu > 5)
            {
                Console.WriteLine("[Erro]: Opção não encontrada.");
                newTest = false;
            }
        }

    } while (!newTest);
    Console.Clear();
    if (optionMenu != 5 && optionMenu != 2)
    {
        number = metodos.InfoNumber();
    }

    switch (optionMenu)
    {
        case 1:
            if (vetorNumber.BinarySearch(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{vetorNumber.BinarySearch(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 2:
            vetorNumber.CopyTo(vetorAlternative, 0);
            for (int index = 0; index < vetorAlternative.Length; index++)
            {
                Console.Write($"[{vetorAlternative[index]}] ");
            }
            Console.WriteLine();
            break;
        case 3:
            if (vetorNumber.IndexOf(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{vetorNumber.IndexOf(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 4:
            if (vetorNumber.LastIndexOf(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{vetorNumber.LastIndexOf(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 5:
            Console.WriteLine("Fim do progama.");
            newTest = false;
            break;

        default:
            Console.WriteLine("[Erro]: Opção não encotrada");
            newTest = false;
            break;
    }
} while (newTest);
