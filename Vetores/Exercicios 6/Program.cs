Console.Clear();
string[] nomes = new string[10];

//Le os nomes 

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o nome da pessoa {i + 1}");
    nomes[i] = Console.ReadLine().ToLower().Trim(' ');
    Console.Clear();
}

Console.WriteLine($"Digite qual o nome que voce quer buscar");
string busca = Console.ReadLine().ToLower().Trim(' ');

bool achou = false;

for (var i = 0; i < 10; i++)
{
    if (nomes[i] == busca)
    {
        achou = true;
    }
}

if (achou)
{
    Console.WriteLine($"ACHEI !! :)");
    
}
else
{
    Console.WriteLine($"NAO ACHEI !!!! :()");
    
}