// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N


while (true)
{
    Console.Write("Введите число (для выхода нажмите 'q'): ");

    string input = Console.ReadLine();

    if ("q".Equals(input)) { break; }

    if (int.TryParse(input, out int value))
    {
        for (int count = 1; count <= value; count++)
        {
            if (count % 2 == 0) { Console.WriteLine(count); }
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Вы указали неверные данные!");
    }
}

