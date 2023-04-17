Console.Clear();
int[] numeros = new int[15];
for (var i = 0; i < 15; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero");
    numeros[i] = int.Parse(Console.ReadLine());
    Console.Clear();
}

Console.WriteLine($"Os numeros escritos em ordem inversa");

for (var i = 14; i >= 0; i--)
{
    Console.WriteLine($"{numeros[i]}");
}