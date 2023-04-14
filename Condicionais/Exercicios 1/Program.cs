Console.Clear();
Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

if (idade >= 16)
{
    Console.WriteLine("Você pode votar este ano!");
}
else
{
    Console.WriteLine("Você não pode votar este ano.");
}