// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = int.Parse(Console.ReadLine());

        // Получаем вторую цифру числа
        int secondDigit = (number / 10) % 10;

        Console.WriteLine($"Вторая цифра числа: {secondDigit}");
    }
}
