﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int res = 0;
int num1;
int sum = 0;

for (sum = 0; num > 0; sum += res)
{
    res = num % 10;
    num = num / 10;
}
Console.WriteLine($"Сумма цифр во введённом числе —> {sum}");