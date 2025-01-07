Console.WriteLine("DO WHILE \n");




var i = 1;

do
{
    Console.WriteLine($"i = {i}"); //faço o loop, incrementando em baixo, coloco a condição if para parar qnd chegar em 8
    i++;
    
}
while (i<=10); //a condição while de ate onde o loop acima vair ir, o do vai executar pelo menos 1 vez

Console.WriteLine();




Console.WriteLine("--------------------------------------");



var x = 1;



do
{
    Console.WriteLine($"x = {x}");
    x++;
    if (x>10) { break; }
}
while (true);






Console.ReadKey();