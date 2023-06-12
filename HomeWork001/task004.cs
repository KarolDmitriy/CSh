// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Чётные числа от 1 до {n}:");
        for (int i = 2; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
