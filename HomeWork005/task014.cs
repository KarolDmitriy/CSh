using System;

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначные числа через запятую:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');

        int evenCount = 0;
        foreach (string numberStr in numbers)
        {
            int number = int.Parse(numberStr.Trim());
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество чётных чисел: {evenCount}");
    }
}
