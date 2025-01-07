/*Use switch para múltiplas condições baseadas no mesmo valor.
  Use if-else para condições mais variadas e complexas.*/
Console.WriteLine("switch\n");

Console.WriteLine("Valor da compra R$ 600,00\n");
var valor = 600;

Console.WriteLine("Informe o número de parcelas(1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());


switch (numeroParcelas)
{
    case 1: //caso o numero de parcelas seja 1
        Console.WriteLine($"Prestação: {valor/numeroParcelas}");
        break;
    case 2: // caso o numero de parcelas seja 2
        Console.WriteLine($"Prestação: {valor / numeroParcelas}");
        break ;
    case 3: // caso o numero de parcelas seja 3
        Console.WriteLine($"Prestação: {valor / numeroParcelas}");
        break;
    default:
        Console.WriteLine("Digite uma parcela válida");
        break ;



}

Console.ReadKey();