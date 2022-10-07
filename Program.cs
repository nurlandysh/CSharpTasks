// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);

if (x > y)

{
    Console.WriteLine("Число {x} больше числа {y}");
}
else
{
    Console.WriteLine("Число {x} меньше числа {y}");
}