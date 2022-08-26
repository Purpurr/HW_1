// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int originNumber = number;
int reverseNumber = 0;

while (number > 0)
{
    int a = number % 10;
    reverseNumber = reverseNumber * 10 + a;
    number = number / 10;
}
if (originNumber == reverseNumber)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");