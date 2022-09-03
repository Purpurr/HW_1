// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] mass = new double[5];      // Создаём массив
Random rnd = new Random();      // Создание объекта для генерации чисел 
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(-10, 10);  // Заполнение рандомами
    Console.Write($" {mass[i]} ");
}
double min = 0;
double max = 0;
foreach (double i in mass)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine();
Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");