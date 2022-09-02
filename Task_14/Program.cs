// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
///[345, 897, 568, 234] -> 2

int[] myArray;
myArray = new int[10];
Random rand = new Random();
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(100, 1000);
    if (myArray[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine(count);