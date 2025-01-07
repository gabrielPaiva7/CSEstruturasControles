Console.WriteLine("FOR ANINHADO");



for (int x = 0; x<5; x++)
{
    for (int y = 0; y < 5; y++) 
    {
        Console.WriteLine($"({x} = {x},{y} = {y})");
    }
    Console.WriteLine();
}



Console.ReadKey();