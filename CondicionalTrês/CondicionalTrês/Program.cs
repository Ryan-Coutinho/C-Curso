int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

if (x % y == 0)
{
    Console.WriteLine($"{x} é multiplo de {y}");
}
else if (y % x == 0)
{
    Console.WriteLine($"{y} é multiplo de {x}");
}
else
{
    Console.WriteLine("Não são multiplos");
}