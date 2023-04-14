Console.Clear();
int[] valores = new int[10];
int maiorValor = 0;
int menorValor = 0;
// Lê os valores digitados pelo usuário
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º valor:");

    valores[i] = int.Parse(Console.ReadLine());

    if (i == 0)
    {
        maiorValor = valores[i];
        menorValor = valores[i];
    }
    else
    {

        if (valores[i] > maiorValor)
        {
            maiorValor = valores[i];
        }
        if (valores[i] < menorValor)
        {
            menorValor = valores[i];
        }
    }
Console.Clear();
}
// Exibe o resultado
Console.WriteLine($"O maior valor digitado foi:{maiorValor}");
Console.WriteLine($"O menor valor digitado foi:{menorValor}");
Console.ReadLine();