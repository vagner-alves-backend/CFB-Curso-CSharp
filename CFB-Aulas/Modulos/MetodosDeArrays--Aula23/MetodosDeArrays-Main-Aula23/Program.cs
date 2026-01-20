using MetodosDeArrays_ModelsClass_Aula23.Models;
MenuDeMetodos metodos = new();

bool newTest = true;

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
            if (metodos.VetorInfo.BinarySearch(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{metodos.VetorInfo.BinarySearch(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 2:
            metodos.VetorInfo.CopyTo(metodos.VetorAlternative, 0);
            for (int index = 0; index < metodos.VetorAlternative.Length; index++)
            {
                Console.Write($"[{metodos.VetorAlternative[index]}] ");
            }
            Console.WriteLine();
            break;
        case 3:
            if (metodos.VetorInfo.IndexOf(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{metodos.VetorInfo.IndexOf(number)}]");
            } else
            {
                Console.WriteLine("O valor informado não foi encontrado.");
            }
            break;
        case 4:
            if (metodos.VetorInfo.LastIndexOf(number) != -1)
            {
                Console.WriteLine($"O valor informado está no index [{metodos.VetorInfo.LastIndexOf(number)}]");
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
