//Quando o número de repetições for conhecido use o loop for
Console.WriteLine("REPETIÇÃO FOR\n");


int numero;

Console.WriteLine("Informe o número\n");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();



for (int i = 1; i <=10; i++)
{
    if (numero<=0)
    {
        Console.WriteLine("informe um número válido");
        break;
        
    }

    Console.WriteLine($"{numero} X {i} = {numero*i}");
}
     

Console.ReadKey();
