// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int N = 1;
while (N<=x)
{
    if (N % 2 == 0)

    Console.Write($"{N} ");
    N = N +1;
}