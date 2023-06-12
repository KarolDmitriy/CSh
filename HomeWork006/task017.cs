// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через запятую:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');
        int count = 0;

        foreach (string number in numbers)
        {
            int num = int.Parse(number.Trim());

            if (num > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел больше нуля: {count}");
    }
}
