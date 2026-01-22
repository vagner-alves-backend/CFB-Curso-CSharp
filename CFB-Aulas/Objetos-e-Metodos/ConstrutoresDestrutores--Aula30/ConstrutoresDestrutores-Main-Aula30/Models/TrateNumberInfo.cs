using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores_Main_Aula30.Models
{
    // Valida se o valor informado é um número.
    public static class TrateNumberInfo
    {
        public static int NumberValid(string? numberInfo)
        {
            int number = 0;
            bool isNumber = int.TryParse(numberInfo, out int notValid);
            while (!isNumber)
            {
                Console.Write(
                    "\t[Erro]: The value info not is number.\n"+
                    "Info Number valid..: "
                );
                isNumber = int.TryParse(numberInfo = Console.ReadLine(), out notValid);
            }
            number = Convert.ToInt32(numberInfo);
            return number;
        }
    }
}