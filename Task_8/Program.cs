﻿//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i * i * i);
}

// Второй вариант через метод:

// Console.WriteLine("Введите число N: ");
// double N = Convert.ToDouble(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//    double result = Math.Pow(i, 3);
//    Console.WriteLine(result);
// }