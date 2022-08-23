// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int num = new Random().Next(1, 1000);
Console.WriteLine("Случайное число = " + num);

if (num > 100)
{
    while (num >= 1000)
    {
        num = num / 10;
    }

    int res = num % 10;
    Console.WriteLine($"Третья цифра числа {num} - {res}");
}
else
{
    Console.WriteLine($"Во введённом числе {num} нет третьей цифры");
}