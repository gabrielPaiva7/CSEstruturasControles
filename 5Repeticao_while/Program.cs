Console.WriteLine("REPETIÇÃO WHILE\n");

var i = 0;

while (i<=10) //enquanto i(0) for menor ou igual a 10
{
    Console.WriteLine($"i = {i}\n"); //repete isso
    i++; //incrementando de 1 em 1
}


Console.WriteLine("\nDigite um número maior que 0");
var numero = Convert.ToInt32(Console.ReadLine()) ;
var contador = 1;



if (numero>0)
{
    Console.WriteLine($"Tabuada do número {numero}\n");
    while (contador<=10)
    {
        
        Console.WriteLine($"{numero} + {contador} = {numero + contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("Digite um número válido");
}



Console.ReadKey();
