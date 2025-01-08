Console.WriteLine("exercicio\n");

//1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior

Console.WriteLine("Informe o primeiro número:");
var numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe o segundo número:");
var numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Informe o terceiro número:");
var numero3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"{numero1} é o maior número\n");
}
else if (numero2 > numero1 && numero2 > numero3) 
{
    Console.WriteLine($"{numero2} é o maior número\n");
}
else if(numero3>numero1 && numero3 > numero2)
{
    Console.WriteLine($"{numero3} é o maior número \n");
}
else
{
    Console.WriteLine("não existe número maior");
}

Console.ReadKey();









