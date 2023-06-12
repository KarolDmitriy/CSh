// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        int sum = CalculateDigitSum(number);

        Console.WriteLine($"Сумма цифр в числе: {sum}");
    }

    static int CalculateDigitSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }
}
