Console.Clear();
string nome;
int quantidade;
float precoUni, total, desconto, totalPagar;

Console.WriteLine("Digite o nome do produto:");
nome = Console.ReadLine();
Console.Clear();

Console.WriteLine("Digite a quantidade adquirida:");
quantidade = int.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Digite o preço unitário:");
precoUni = float.Parse(Console.ReadLine());
Console.Clear();

total = quantidade * precoUni;

if (quantidade <= 5)
{
    desconto = total * 0.02f;
}
else if (quantidade >5 && quantidade <= 10)
{
    desconto = total * 0.03f;
}
else
{
    desconto = total * 0.05f;
}

totalPagar = total - desconto;

Console.WriteLine($"Descrição do produto: {nome}");
Console.WriteLine($"Quantidade adquirida: {quantidade}");
Console.WriteLine($"Preço unitário: {precoUni:C2}");
Console.WriteLine($"Total: {total:C2}");
Console.WriteLine($"Desconto: {desconto:C2}");
Console.WriteLine($"Total a pagar: {totalPagar:C2}");