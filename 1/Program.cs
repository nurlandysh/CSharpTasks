﻿// Напишите программу которая принимает на входе два числа 
// и проверяет является ли первое число квадратом второго

Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine()!);

if(y*y ==x)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет");
}