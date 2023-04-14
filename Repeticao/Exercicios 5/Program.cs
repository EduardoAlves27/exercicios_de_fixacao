for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {i}");

    for (int r = 1; r <= 10; r++)
    {
        int resultado = i * r;
        Console.WriteLine($"{i} X {r} = {resultado}");
        
    }
    Console.WriteLine();
}


