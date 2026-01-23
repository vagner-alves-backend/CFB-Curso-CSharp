using Heranca_Main_Aula34.Models;

Carro[] carro = [
    new("5432786-98" ,"KLM-657", true, false, false, 12.6), 
    new("4839532-87", "FTP-876"), 
    new(false, false, true, 10.5)
];

for (int index = 0; index < carro.Length; index++) 
{
    carro[index].CarroPropriedades();
}
