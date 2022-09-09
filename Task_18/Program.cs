﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double point1 = (b2 - b1) / (k1 - k2);
double point2 = (k1 * b2 - k2 * b1) / (k1 - k2);

if (k1 != k2)
{
    Console.WriteLine("");
    Console.WriteLine($"Прямые имеют точку пересечения ({point1:f2} ; {point2:f2})");
}
else
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые не являются параллельными.");
    }
    else
    {
        Console.WriteLine("Прямые параллельны.");
    }
}