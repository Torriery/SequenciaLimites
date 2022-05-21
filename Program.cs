Console.Write("bote algum numero: ");
int inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("bote outro numero :");
int fim = Convert.ToInt32(Console.ReadLine());

if (fim >= inicio)
{
    int n = inicio;

    while (n <= fim)
    {
        Console.Write($"{n} ");
        n += 1;
    }
}
else
{
    Console.WriteLine("Não é possível terminar antes de iniciar.");
}