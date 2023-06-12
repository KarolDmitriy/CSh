// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа, разделенные запятой:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');

        int sum = 0;
        for (int i = 1; i < numbers.Length; i += 2)
        {
            int number = int.Parse(numbers[i]);
            sum += number;
        }

        Console.WriteLine($"Сумма элементов с нечетными индексами: {sum}");
    }
}
