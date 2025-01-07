Console.WriteLine("else-if\n");

Console.WriteLine("informe a nota do aluno:");
var nota = Convert.ToInt32(Console.ReadLine());


if (nota < 5) //SE nota maior que 5
{
    Console.WriteLine("ALUNO REPROVADO!!!!");
}
else if (nota >= 5 && nota <= 7) //SENAO nota maiorIgual a 5 E nota menorIgual a 7
{
    Console.WriteLine("ALUNO EM RECUPERAÇÃO");
}
else if(nota >= 8) //SENAO nota maiorIgual a 8
{
    Console.WriteLine("APROVADO");
}




Console.ReadKey();
