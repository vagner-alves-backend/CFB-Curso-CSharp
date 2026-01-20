using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosDeArrays_ModelsClass_Aula23.Models
{
    public class MenuDeMetodos
    {

        public int[] VetorInfo = new int[17];
        public int[] VetorAlternative = new int[17];
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