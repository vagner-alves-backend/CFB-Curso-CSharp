using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosDeArrays_ModelsClass_Aula23.Models
{
    public class MenuDeMetodos
    {
        public int[] VetorInfo = [1, 2, 3, 4, 5, 6, 7, 8, 9, 5, 4, 2, 1, 8, 9, 6, 5];
        public int[] VetorAlternative = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
        public int NumberInfor {get; set;}
        public int InfoNumber()
        {
            bool checkNumberValid = true;
            string? numberInfoText = "Null";
            int numberInfo = 0;

            do
            {
                Console.Write("Number: ");
                numberInfoText = Console.ReadLine();
                checkNumberValid = int.TryParse(numberInfoText, out numberInfo);
                if (checkNumberValid == false)
                {
                    Console.WriteLine("[Erro]: Valor invalido.");
                } else
                {
                    numberInfo = Convert.ToInt32(numberInfoText);
                }
            } while (!checkNumberValid);

            NumberInfor = numberInfo;
            return numberInfo;
        }
    }
}