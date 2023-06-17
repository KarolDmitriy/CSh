// Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSum(m, n);

        Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}.");
    }

    static int CalculateSum(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        else
        {
            return m + CalculateSum(m + 1, n);
        }
    }
}
