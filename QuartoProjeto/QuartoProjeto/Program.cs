int funcionario = int.Parse(Console.ReadLine()!);
int horaTrabalhada = int.Parse(Console.ReadLine()!);
double valorHora = double.Parse(Console.ReadLine()!);

double salario = horaTrabalhada * valorHora;

Console.WriteLine($"NUMBER = {funcionario}");
Console.WriteLine($"SALARY = U$ {salario:f2}");
