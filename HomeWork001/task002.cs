// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число:");
        int num3 = int.Parse(Console.ReadLine());

        int max = num1; // Предполагаем, что первое число - максимальное

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine($"Максимальное число: {max}");
    }
}
