int numero = 0;
int soma = 0;

Console.WriteLine("Digite seu numero entre 5 e 9");
numero = int.Parse(Console.ReadLine());

for (int x = 1; x <= numero; x++)
{
    if (x == numero)
    {
        Console.Write(x);
    }
    else
    {
        Console.Write(x + "+");
    }
    
    soma += x;
}
Console.Write("=" + soma);
