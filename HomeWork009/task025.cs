// Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа, кратные 3, в промежутке от {m} до {n}:");
        PrintMultiplesOfThree(m, n);
    }

    static void PrintMultiplesOfThree(int start, int end)
    {
        if (start > end)
            return;

        if (start % 3 == 0)
            Console.WriteLine(start);

        PrintMultiplesOfThree(start + 1, end);
    }
}
