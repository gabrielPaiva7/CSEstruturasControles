Console.WriteLine("## Estrutura if else ##\n");

Console.WriteLine("Escreva sua nota\t");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 10) 
{
    Console.WriteLine("APROVADO!!!!");

}
else
{
    Console.WriteLine("REPROVADO!!!!");
}

Console.WriteLine("-----------------------------------");

Console.WriteLine("Informe o valor de x");
var x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
var y = Convert.ToDouble(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    Console.WriteLine("x não é maior que y");
}











Console.ReadKey();
