// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Укажите количество чисел, которое Вы хотите ввести: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"Введите число №{index + 1}: ");
        int N = Convert.ToInt32(Console.ReadLine());
        array[index] = N;
        index++;
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

int[] array = new int[m];


FillArray(array);
Console.WriteLine("Вы ввели: ");
PrintArray(array);
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        res += 1;
    }
}
Console.WriteLine(" ");

Console.WriteLine($"Из этих чисел больше 0 — {res} числа");