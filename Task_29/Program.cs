/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

Console.Write("Введите значение N: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите значение M: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"n={n}, m={m}");

if (m > n)
    for (int i = n; i <= m; i++)
        Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");