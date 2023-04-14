using System.Globalization;

Console.Clear();

Console.WriteLine($"Ola bem vindo ao nosso posto ");
Thread.Sleep(2500);
here:
Console.WriteLine($"Qual combustivel gostaria");
Console.WriteLine($"Sendo A...... Alcool");
Console.WriteLine($"Sendo G...... Gasolina");
char tipo = char.Parse(Console.ReadLine().ToUpper());
Console.Clear();
Console.WriteLine(@$"alcool:
. ate 20 litros, desconto de 3% por litro alcool
. acima de 20 litros, desconto de 5% por litro");

Console.WriteLine(@$"Gasolina:
. ate 20 litros, desconto de 4% por litro Gasolina
. acima de 20 litros, desconto de 6% por litro");


Console.WriteLine($"Essa e a nossa promocao");
Console.WriteLine($"Sendo o valor do alcool R$4,90");
Console.WriteLine($"Sendo o valor da Gasolina R$5,30");
Console.WriteLine($"Quantos litro voce gostaria");
float litros = float.Parse(Console.ReadLine());
Console.Clear();

double precoLitro;
float desconto;

if (tipo == 'A')
{
    precoLitro = 4.9D;

    if (litros <= 20)
    {
        desconto = litros * 0.03f;
    }
    else
    {
        desconto = litros * 0.05f;
    }
}
else if (tipo == 'G')
{
    precoLitro = 5.3D;

    if (litros <= 20)
    {
        desconto = litros * 0.04f;
    }
    else
    {
        desconto = litros * 0.06f;
    }
}
else
{
    Console.WriteLine("Tipo de combustível inválido.");
    goto here;
}

double valorSD = precoLitro * litros;
double valorCD = valorSD - desconto;

Console.WriteLine($"O Valor do Combustivel foi de  {Math.Round(valorCD, 2).ToString("C", new CultureInfo("pt-BR"))}");




