﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
 Console.WriteLine("Максимальное число: " + max);