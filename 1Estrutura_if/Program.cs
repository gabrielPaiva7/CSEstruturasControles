Console.WriteLine("## Estrutur if ## \n");



Console.WriteLine("É um cliente especial? (SIM/NAO)");
var cliente = Console.ReadLine();

if (cliente == "SIM")  //SE cliente for SIM
{
    Console.WriteLine("Desconto de 10%"); //mostre isso na tela
}

else
{
    Console.WriteLine("Fim do processo!");//caso contrário, mostre isso
}

Console.WriteLine("---------------------------------------------------");



Console.ReadKey();
