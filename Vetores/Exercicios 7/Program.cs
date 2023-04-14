Console.Clear();
int[] numeros = new int[15];
int numero;
for (var i = 1; i < 16; i++)
{
    Console.WriteLine($"Digite o {i}º numero");
    numeros[i] = int.Parse(Console.ReadLine());
    Console.Clear();
}

Console.WriteLine($"Os numeros escritos em ordem inversa");

for (var i = 15; i >= 1; i--)
{
    Console.WriteLine($"{numeros[i]}");
    
}